using Komora.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Komora.Classes.Segment
{
    public class StartSegment : Segment
    {

        public StartSegment(SegmentData segmentData)
            : base(segmentData.timeSeconds, segmentData.acquisitionRateMinutes)
        {
            segmentType = SEGMENT_TYPE.start;

            endTemperature = segmentData.endTemperature;

            ledON = segmentData.ledOn;
            ledCurrent = ledON ? segmentData.ledCurrent : 0;

            timer1000ms.Elapsed += new System.Timers.ElapsedEventHandler(checkForSegmentEnd);
        }

        private void checkForSegmentEnd(object sender, System.Timers.ElapsedEventArgs e)
        {
            //sprtawdzenie warunku konca segmetn dziala conajmniej 5 sekund aby ustabilizowac odczyt
            //if (this.endTemperature <= converterRT.ResistanceToTemperature(this.controllerValues.heater_Params.pv) && timerTicks > 2)
            if(pt100Converter.temperatureToResistance(endTemperature) <= controllerValues.heater_Params.pv && DateTime.Now > startTime.AddSeconds(5))
            {
                timer1000ms.Stop();
                Finish();
                return;
            }
        }

        public override void Start()
        {
         //  MessageBox.Show("start starts");
            base.Start();
            startTime = DateTime.Now;
            sendEndTemperatureToController();
            sendLedCurrentToController();

            timer1000ms.Enabled = true;
        }

        private void sendLedCurrentToController()
        {
            //DIODE CONVERTER
            if (ledON)
            {
                //atCommand.AT_DIODE_SP()
            }
        }

        private void sendEndTemperatureToController()
        {
            var result = pt100Converter.temperatureToResistance(endTemperature);
            atCommand.AT_HEATER_SP(result);
        }

        public override void Finish()
        {
           // MessageBox.Show("start ends");
            base.Finish();
        }

        public override object[] DataTableRow()
        {
            return new object[] {"Start", "-", endTemperature, "?", acquisitionRateMinutes.ToString("0.000"), "-"};
        }
    }
}

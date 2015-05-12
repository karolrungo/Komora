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

        private int timerTicks; //zmienna pomocnicza, aby timer wykonal sie conajmniej kilka razy

        public StartSegment(SegmentData segmentData)
            : base(segmentData.timeSeconds, segmentData.acquisitionRateMinutes)
        {
            segmentType = SEGMENT_TYPE.start;

            endTemperature = segmentData.endTemperature;

            ledON = segmentData.ledOn;
            ledCurrent = ledON ? segmentData.ledCurrent : 0;

            timer1000ms.Elapsed += new System.Timers.ElapsedEventHandler(checkForSegmentEnd);
            timerTicks = 0;
        }

        private void checkForSegmentEnd(object sender, System.Timers.ElapsedEventArgs e)
        {
            //sprtawdzenie warunku konca
            //if (this.endTemperature <= converterRT.ResistanceToTemperature(this.controllerValues.heater_Params.pv) && timerTicks > 2)
            if(pt100Converter.temperatureToResistance(endTemperature) <= controllerValues.heater_Params.pv)
            {
                timer1000ms.Stop();
                Finish();
                return;
            }

            timerTicks++;
        }

        public override void Start()
        {
         //  MessageBox.Show("start starts");
            base.Start();
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

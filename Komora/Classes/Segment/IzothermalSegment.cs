using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Komora.Classes.Segment
{
    public class IzothermalSegment : Segment
    {
        public IzothermalSegment(SegmentData segmentData)
            : base(segmentData.timeSeconds, segmentData.acquisitionRateMinutes)
        {
            segmentType = SEGMENT_TYPE.izothermal;

            ledON = segmentData.ledOn;
            ledCurrent = ledON ? segmentData.ledCurrent : 0;

            timer1000ms.Elapsed += new System.Timers.ElapsedEventHandler(checkForSegmentEnd);
        }

        private void checkForSegmentEnd(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.endTime < DateTime.Now)
            {
                Finish();
                return;
            }
        }

        public override void Start()
        {
         //   MessageBox.Show("izo start");
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
            atCommand.AT_HEATER_SP(pt100Converter.temperatureToResistance(endTemperature));
        }

        public override void Finish()
        {
        //    MessageBox.Show("izo finish");
            base.Finish();
        }

        public override object[] DataTableRow()
        {
            return new object[] { "Izothermal", startTemperature , endTemperature, durationTimeSeconds, acquisitionRateMinutes.ToString("0.000"), "-"};
        }
    }
}

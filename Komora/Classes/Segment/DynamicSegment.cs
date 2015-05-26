using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Segment
{
    public class DynamicSegment : Segment
    {
        public DynamicSegment(SegmentData segmentData)
            : base(segmentData.timeSeconds, segmentData.acquisitionRateMinutes)
        {
            this.endTemperature = segmentData.endTemperature;
            this.heatingRateMinutes = segmentData.heatingRate;
            this.heatingRateSeconds = this.heatingRateMinutes / 60;
        }

        public override object[] DataTableRow()
        {
            return new object[] { "Dynamic", startTemperature, endTemperature, durationTimeSeconds, acquisitionRateMinutes.ToString("0.000"), heatingRateMinutes};
        }
    }
}

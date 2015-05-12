using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Segment
{
    public class DynamicSegment : Segment
    {
        public override object[] DataTableRow()
        {
            return new object[] { "Dynamic", startTemperature, endTemperature, durationTimeSeconds, acquisitionRateMinutes.ToString("0.000"), heatingRateMinutes};
        }
    }
}

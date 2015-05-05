using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Segment
{
    public class IzothermalSegment : Segment
    {
        public IzothermalSegment(bool p_ledOn, long p_ledCurrent, long p_tempStart, long p_tempEnd, double p_acquisitionRate) :
            base(p_ledOn, p_ledCurrent, p_tempStart, p_tempEnd, p_acquisitionRate)
        {
        }

        public override void startProcessing()
        {
            base.startProcessing();
        }

        public override void endProcessing()
        {
            base.endProcessing();
        }
    }
}

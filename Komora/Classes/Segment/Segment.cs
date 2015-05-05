using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Segment
{
    public abstract class Segment
    { 
        public bool ledON;
        public long ledCurrent;

        public long temperatureStart;
        public long temperatureEnd;

        public SEGMENT_STATUS segmentStatus;
        public double acquisitionRate;

        public Segment()
        { }

        public Segment(bool p_ledOn, long p_ledCurrent, long p_tempStart, long p_tempEnd, double p_acquisitionRate)
        {
            ledON = p_ledOn;
            ledCurrent = ledON ? p_ledCurrent : 0;
            temperatureStart = p_tempStart;
            temperatureEnd = p_tempEnd;
            segmentStatus = SEGMENT_STATUS.WAITING;
        }

        public virtual void startProcessing()
        {
            segmentStatus = SEGMENT_STATUS.PROCESSING;
        }
        public virtual void endProcessing()
        {
            segmentStatus = SEGMENT_STATUS.DONE;
        }

    }
}

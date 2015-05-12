using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Segment
{
    public class SegmentFactory
    {
        internal Segment createSegment(SEGMENT_TYPE segmentType, SegmentData segmentData)
        {
            switch (segmentType)
            {
                case SEGMENT_TYPE.start:
                    return new StartSegment(segmentData);
                case SEGMENT_TYPE.izothermal:
                    return new IzothermalSegment(segmentData);

                default:
                    throw new Exception("Wrong segment type selected");
            }
        }
    }
}

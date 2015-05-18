using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komora.Classes.Segment
{
    public class SegmentEventArgs
    {
        public int actualSegment;
        public SEGMENT_TYPE sEGMENT_TYPE;

        public SegmentEventArgs(int actualSegment, SEGMENT_TYPE sEGMENT_TYPE)
        {
            this.actualSegment = actualSegment;
            this.sEGMENT_TYPE = sEGMENT_TYPE;
        }
    }
}

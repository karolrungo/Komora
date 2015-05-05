using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Segment
{
    public class SegmentList : IEnumerable
    {
        private List<Segment> segmentList;
        public int actualSegment;

        public SegmentList()
        {
            segmentList = new List<Segment>();
        }

        public void Add(Segment segment)
        {
            if (emptyList() && segment is StartSegment)
            {
                segmentList.Add(segment);
            }
            else if (!emptyList() && isDynamicOrIzothermalSegment(segment))
            {
                segmentList.Add(segment);
            }
            else
            {
                throw new Exception("Wrong segment type");
            }
        }

        private static bool isDynamicOrIzothermalSegment(Segment segment)
        {
            return segment is DynamicSegment || segment is IzothermalSegment;
        }

        private bool emptyList()
        {
            return segmentList.Count == 0 ? true : false;
        }

        public IEnumerator<Segment> GetEnumerator()
        {
            return segmentList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

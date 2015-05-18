using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.Classes.Segment
{
    public class SegmentList : IEnumerable
    {
        public delegate void TimerTickedEvent(object sender, SegmentEventArgs e);
        public event TimerTickedEvent AcquisitionRateTimerTicked;

        public List<Segment> segmentList;
        public int actualSegment;
        private Classes.Communication.AT_Command atCommand;

        public SegmentList()
        {
            segmentList = new List<Segment>();
            actualSegment = 0;
        }

        public void Add(Segment segment)
        {
            if (emptyList() && segment is StartSegment)
            {
                segmentList.Add(segment);
            }
            else if (!emptyList() && isDynamicOrIzothermalSegment(segment))
            {
                setTemperaturesForDynamicOrIozthermalSegment(ref segment);
                segmentList.Add(segment);
            }
            else
            {
                throw new Exception("Wrong segment type");
            }
        }

        private void setTemperaturesForDynamicOrIozthermalSegment(ref Segment segment)
        {
            if (segment is IzothermalSegment)
            {
                segment.startTemperature = segmentList[segmentList.Count - 1].endTemperature; //zczytaj koncowa temp z segmentu poprzedniego
                segment.endTemperature = segment.startTemperature; // temp startowa = koncowa
            }
            if (segment is DynamicSegment)
            {
                segment.startTemperature = segmentList[segmentList.Count - 1].endTemperature; //zczytaj koncowa temp z segmentu poprzedniego
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

        public DataTable ToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Type");
            dt.Columns.Add("Start temp. [oC]");
            dt.Columns.Add("End temp. [oC]");
            dt.Columns.Add("Duration time [s]");
            dt.Columns.Add("Acquisition rate [p/min]");
            dt.Columns.Add("Heating rate [K/min]");

            foreach (Segment segment in segmentList)
            {
                dt.Rows.Add(segment.DataTableRow());

            }
            return dt;
        }

        //WAZNE!!!!!!!!!
        public  void catchAcquisitionRateTimerTicks()
        {
            foreach (Segment segment in segmentList)
            {
                segment.AcquisitionRateTimerTicked += segment_AcquisitionRateTimerTicked;
            }
        }

        private void segment_AcquisitionRateTimerTicked(object sender, EventArgs e)
        {
            if (AcquisitionRateTimerTicked != null)
            {
                AcquisitionRateTimerTicked(this, new SegmentEventArgs(actualSegment, segmentList[actualSegment].segmentType));
            }
        }

        internal void AddSegmentFinishedEventForeachSegment()
        {
            foreach (Segment segment in segmentList)
            {
                segment.SegmentFinished += segment_SegmentFinisched;
            }
        }

        private void segment_SegmentFinisched(object sender, EventArgs e)
        {
            actualSegment++;

            if (actualSegment >= segmentList.Count)
            {
                MessageBox.Show("MEAS END");
                return;
            }
            atCommand.AT_CONTR_SEGMENT(actualSegment + 1);
            segmentList[actualSegment].startTime = DateTime.Now;
            segmentList[actualSegment].endTime = segmentList[actualSegment].startTime.AddSeconds(segmentList[actualSegment].durationTimeSeconds);
            segmentList[actualSegment].Start();
        }

        public void Start()
        {
            atCommand.AT_CONTR_SEGMENT(actualSegment + 1);
            segmentList[actualSegment].Start();
        }

        internal void setControllerValues(ref DataTypes.ControllerValues controllerValues)
        {
            foreach (Segment segment in segmentList)
            {
                segment.controllerValues = controllerValues;
            }
        }

        internal void setAtCommands(ref Communication.AT_Command atCommand)
        {
            this.atCommand = atCommand;
            foreach (Segment segment in segmentList)
            {
                segment.atCommand = atCommand;
            }
        }

        internal void setPt100Converter(Utilities.Pt100converter pt100Converter)
        {
            foreach (Segment segment in segmentList)
            {
                segment.pt100Converter = pt100Converter;
            }
        }
    }
}

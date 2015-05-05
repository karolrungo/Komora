using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Segment
{
    public class SegmentListProcessor
    {
        //zdarzenie updatePlot wysylane do okna pomiarpwego - tam zedgraph controller odswiezy wszystko
        //zdarzeniue AQQRATE - zebranie danych i zapisanie ich do controllerValues

        private SegmentList segmentList;
        private Communication.AT_Command atCommand;
        private DataTypes.ControllerValues controllerValues;
        System.Timers.Timer timer;
        private const double oneSecond = 1000;

        public SegmentListProcessor(SegmentList segmentList, ref Communication.AT_Command atCommand, ref DataTypes.ControllerValues controllerValues)
        {
            this.segmentList = segmentList;
            this.atCommand = atCommand;
            this.controllerValues = controllerValues;

            timer = new System.Timers.Timer(oneSecond);
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
           // checkIfSegmentEnded();
        }

        public void startProcessing()
        {
            foreach (Segment segment in segmentList)
            {
                segment.startProcessing();
               // atCommand.AT_HEATER_SP()
                atCommand.AT_CONTR_SEGMENT(segmentList.actualSegment);
            }
        }

        public void endProcessing()
        {
 
        }
    }
}

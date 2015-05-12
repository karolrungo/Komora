using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Classes.Segment;

namespace Komora.Controls
{
    public partial class StartSegmentData : UserControl
    {
        public StartSegmentData()
        {
            InitializeComponent();
        }

        internal Classes.Segment.SegmentData getSegmentData()
        {
            SegmentData segmentData = new SegmentData();
            segmentData.acquisitionRateMinutes = Double.Parse(TbAcqRate.Text);
            segmentData.endTemperature = Double.Parse(tbEndTemp.Text);

            return segmentData;
        }
    }
}

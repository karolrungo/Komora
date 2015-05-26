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
    public partial class DynamicSegmentData : UserControl
    {
        public DynamicSegmentData()
        {
            InitializeComponent();
        }

        internal Classes.Segment.SegmentData getSegmentData()
        {
            SegmentData segmentData = new SegmentData();
            segmentData.acquisitionRateMinutes = Double.Parse(tbAcquisitionRate.Text);
            segmentData.endTemperature = Double.Parse(tbEndTemperature.Text);
            segmentData.heatingRate = Double.Parse(tbHeatingRate.Text);

            return segmentData;
        }
    }
}

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
    public partial class IzothermalSegmentData : UserControl
    {
        public IzothermalSegmentData()
        {
            InitializeComponent();
        }

        internal SegmentData getSegmentData()
        {
            SegmentData segmentData = new SegmentData();
            segmentData.timeSeconds = getTimeSeconds();
            segmentData.acquisitionRateMinutes = Double.Parse(tbAcquisitionrate.Text);

            return segmentData;
        }

        private int getTimeSeconds()
        {
            string[] splitted = tbIsothermalTime.Text.Split(':');

            if (splitted.ToList().Count != 2)
                throw new Exception("Isothermal time - wrong format!");

            int minutes = Int32.Parse(splitted[0]);
            int seconds = Int32.Parse(splitted[1]);

            return minutes * 60 + seconds;
        }
    }
}

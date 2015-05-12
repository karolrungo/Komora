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
    public partial class SegmentInterfaceControl : UserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler ButtonAddClicked;
        public event ButtonClickedEventHandler ButtonEditClicked;
        public event ButtonClickedEventHandler ButtonDeleteClicked;
        public event ButtonClickedEventHandler ButtonClearListClicked;

        public SegmentInterfaceControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ButtonAddClicked != null)
                ButtonAddClicked(this, e);
        }

        private void btnDeleteSegment_Click(object sender, EventArgs e)
        {
            if (ButtonEditClicked != null)
                ButtonEditClicked(this, e);
        }

        private void btnEditSegment_Click(object sender, EventArgs e)
        {
            if (ButtonDeleteClicked != null)
                ButtonDeleteClicked(this, e);
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            if (ButtonClearListClicked != null)
                ButtonClearListClicked(this, e);
        }

        internal Classes.Segment.SEGMENT_TYPE getSegmentType()
        {
            return segmentTypeControl1.getSegmentType();
        }

        internal Classes.Segment.SegmentData getSegmentData()
        {
            switch (segmentTypeControl1.getSegmentType())
            {
                case SEGMENT_TYPE.start:
                    return segmentTypeControl1.getStartSegmentData();
                //case SEGMENT_TYPE.dynamic:
                //    throw new NotImplementedException();
                //    break;
                case SEGMENT_TYPE.izothermal:
                    return segmentTypeControl1.getIzothermalSegmentData();
                //case SEGMENT_TYPE.final:
                //    throw new NotImplementedException();
                //    break;
                default:
                    throw new ArgumentException("Fatal error while adding segment - error while reading segment data!");
            }
        }

        public void updateSegmentListDataGridView(DataTable dt)
        {
            dgvSegmentList.DataSource = dt;
        }
    }
}

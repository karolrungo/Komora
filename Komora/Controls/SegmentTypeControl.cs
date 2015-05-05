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
    public partial class SegmentTypeControl : UserControl
    {
        public SegmentTypeControl()
        {
            InitializeComponent();
            rBtnStart.CheckedChanged += rb_CheckChanged;
            rBtnDynamic.CheckedChanged += rb_CheckChanged;
            rBtnIzothermal.CheckedChanged += rb_CheckChanged;
            rBthFinal.CheckedChanged += rb_CheckChanged;

            //wylacz wszystkie kontrolki do wprowadzania danych
            SetControlEnabledAndVisibility(startSegmentData1, false);
            SetControlEnabledAndVisibility(dynamicSegmentData1, false);
            SetControlEnabledAndVisibility(izothermalSegmentData1, false);
            //SetControlEnabledAndVisibility(finalSegmentData1, false);
        }

                private void rb_CheckChanged(object sender, EventArgs e)
        {
            try
            {
                SEGMENT_TYPE type = new SEGMENT_TYPE();
                type = getSegmentType(); //to moze rzucic wyjatek!!

                switch (type)
                {
                    case SEGMENT_TYPE.start :
                        SetControlEnabledAndVisibility(startSegmentData1, true);
                        SetControlEnabledAndVisibility(dynamicSegmentData1, false);
                        SetControlEnabledAndVisibility(izothermalSegmentData1, false);
                        //SetControlEnabledAndVisibility(finalSegmentData1, false);
                        break;
                    case SEGMENT_TYPE.dynamic:
                        SetControlEnabledAndVisibility(startSegmentData1, false);
                        SetControlEnabledAndVisibility(dynamicSegmentData1, true);
                        SetControlEnabledAndVisibility(izothermalSegmentData1, false);
                        //SetControlEnabledAndVisibility(finalSegmentData1, false);
                        break;
                    case SEGMENT_TYPE.izothermal:
                        SetControlEnabledAndVisibility(startSegmentData1, false);
                        SetControlEnabledAndVisibility(dynamicSegmentData1, false);
                        SetControlEnabledAndVisibility(izothermalSegmentData1, true);
                        //SetControlEnabledAndVisibility(finalSegmentData1, false);
                        break;
                    case SEGMENT_TYPE.final:
                        SetControlEnabledAndVisibility(startSegmentData1, false);
                        SetControlEnabledAndVisibility(dynamicSegmentData1, false);
                        SetControlEnabledAndVisibility(izothermalSegmentData1, false);
                        //SetControlEnabledAndVisibility(finalSegmentData1, true);
                        break;
                    default:
                        SetControlEnabledAndVisibility(startSegmentData1, false);
                        SetControlEnabledAndVisibility(dynamicSegmentData1, false);
                        SetControlEnabledAndVisibility(izothermalSegmentData1, false);
                        //SetControlEnabledAndVisibility(finalSegmentData1, false);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetControlEnabledAndVisibility(Control control, bool state)
        {
            control.Visible = state;
            control.Enabled = state;
        }

        public SEGMENT_TYPE getSegmentType()
        {
            if (rBtnStart.Checked) return SEGMENT_TYPE.start;
            else if (rBtnDynamic.Checked) return SEGMENT_TYPE.dynamic;
            else if (rBtnIzothermal.Checked) return SEGMENT_TYPE.izothermal;
            else if (rBthFinal.Checked) return SEGMENT_TYPE.final;
            else throw new Exception("None segment type selected");
        }
    }
}

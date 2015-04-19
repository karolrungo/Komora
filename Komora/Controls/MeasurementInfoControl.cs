using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.Controls
{
    public partial class MeasurementInfoControl : UserControl
    {
        private bool afterRejuvenation;

        public MeasurementInfoControl()
        {
            InitializeComponent();
        }

        public DataTypes.MeasurementInfo getMeasurementInfo()
        {
            DataTypes.MeasurementInfo measInfo =  new DataTypes.MeasurementInfo();
            measInfo.measurementName = tbName.Text;
            measInfo.filename = tbFilename.Text;
            measInfo.weight = Double.Parse(tbWeight.Text);
            measInfo.material = tbMaterial.Text;
            measInfo.basicAdditionalInfo = tbAddInfo.Text;
            measInfo.laboratory = tbLaboratory.Text;
            measInfo.synthesisDate = dtpSynthesisDate.Value.Date.AddHours(dtpSynthesisTime.Value.Hour)
                                                                .AddMinutes(dtpSynthesisTime.Value.Minute)
                                                                .AddSeconds(dtpSynthesisTime.Value.Second);
            measInfo._operator = tbOperator.Text;
            measInfo.afterRejuvenation = checkBoxRejuventaion.Checked;


            return measInfo;
        }

        private void checkBoxRejuventaion_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chBox = new CheckBox();
            chBox = (CheckBox)sender;

            afterRejuvenation = chBox.Checked; //zmiana wartosci
            SetEnableForTextBoxesWithRejuvenationInfo();
        }

        private void SetEnableForTextBoxesWithRejuvenationInfo()
        {
            bool state;

            //jesli probka jest po rejuwenacji to nalezy "wylaczyc" textboxy
            if (afterRejuvenation) state = false;
            else state = true;

            tbDarkAged.Text = null;
            tbDarkAged.Enabled = state;
            tbSpecialAged.Text = null;
            tbSpecialAged.Enabled = state;
            tbRejuvenationAdditionalInfo.Text = null;
            tbRejuvenationAdditionalInfo.Enabled = state;
        }
    }
}

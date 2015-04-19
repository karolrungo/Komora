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
            afterRejuvenation = false;
            SetEnableForTextBoxesWithRejuvenationInfo();
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
            measInfo.synthesisDate = dtpSytntesis.getDateAndTime();
            measInfo._operator = tbOperator.Text;
            measInfo.afterRejuvenation = checkBoxRejuventaion.Checked;
            measInfo.rejuvenationDate = dtpRejuvenation.getDateAndTime();
            measInfo.rejuvenationAdditionalInfo = tbRejuvenationAdditionalInfo.Text;
            measInfo.darkAged = tbDarkAged.Text;
            measInfo.specialAged = tbSpecialAged.Text;

            return measInfo;
        }

        public void setMeasurementInfo(DataTypes.MeasurementInfo measInfo)
        {
            tbName.Text = measInfo.measurementName;
            tbFilename.Text = measInfo.filename;
            tbWeight.Text = measInfo.weight.ToString();
            tbMaterial.Text = measInfo.material;
            tbAddInfo.Text = measInfo.basicAdditionalInfo;
            tbLaboratory.Text = measInfo.laboratory;
            dtpSytntesis.setDateAndTime(measInfo.synthesisDate);
            measInfo._operator = tbOperator.Text;
            checkBoxRejuventaion.Checked = measInfo.afterRejuvenation;
            dtpRejuvenation.setDateAndTime(measInfo.rejuvenationDate);
            tbRejuvenationAdditionalInfo.Text = measInfo.rejuvenationAdditionalInfo;
            tbDarkAged.Text = measInfo.darkAged;
            tbSpecialAged.Text = measInfo.specialAged;

            SetEnableForTextBoxesWithRejuvenationInfo();
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
            tbDarkAged.Enabled = afterRejuvenation;
            tbSpecialAged.Enabled = afterRejuvenation;
            tbRejuvenationAdditionalInfo.Enabled = afterRejuvenation;
            if (!afterRejuvenation)
            {
                tbDarkAged.Text = null;
                tbSpecialAged.Text = null;
                tbRejuvenationAdditionalInfo.Text = null;
            }
        }
    }
}

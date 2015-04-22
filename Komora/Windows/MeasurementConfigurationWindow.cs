using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Controls;

namespace Komora.Windows
{
    public partial class MeasurementConfigurationWindow : Form
    {
        private Classes.DataBase.LinqDataBaseConnector databaseConnector;
        private DataTypes.MeasurementInfo measurementInfo;
        private Classes.Communication.SerialPortValidator serialPortValidator;

        public MeasurementConfigurationWindow()
        {
            InitializeComponent();

            serialPortValidator = new Classes.Communication.SerialPortValidator();
            databaseConnector = new Classes.DataBase.LinqDataBaseConnector();
            databaseConnector.connect();
            measurementInfo = new DataTypes.MeasurementInfo();

            dgvChambers.DataSource = databaseConnector.selectCalibratedChambers();
        }

        private void btnStartMeasurement_Click(object sender, EventArgs e)
        {
            try
            {
                string serialPort = getSerialPortFromDataGridView();
                measurementInfo = measurementInfoControl.getMeasurementInfo();
                databaseConnector.saveMeasurementInfo(measurementInfo);

                MeasurementForm measurementForm = new MeasurementForm(serialPort, measurementInfo);
                measurementForm.Show(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getSerialPortFromDataGridView()
        {
            if (onlyOneRowSelected(dgvChambers))
            {
                string serialPortName = dgvChambers.SelectedRows[0].Cells["serialPort"].Value.ToString();
                if (!serialPortValidator.portExists(serialPortName))
                {
                    throw new Exception("Port " + serialPortName + " does not exists!");
                }
                return serialPortName;
            }
            else
            {
                throw new Exception("Select only one chamber!");
            }
        }

        private bool onlyOneRowSelected(DataGridView dgv)
        {
            return (dgv.SelectedRows.Count == 1) ? true : false;
        }
    }
}

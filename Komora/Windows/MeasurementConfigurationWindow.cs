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
        private DataTypes.MeasurementInfo measInfo;
        private Classes.Communication.SerialPortValidator serialPortValidator;

        public MeasurementConfigurationWindow()
        {
            InitializeComponent();

            serialPortValidator = new Classes.Communication.SerialPortValidator();
            databaseConnector = new Classes.DataBase.LinqDataBaseConnector();
            databaseConnector.connect();

            measInfo = new DataTypes.MeasurementInfo();

            dgvChambers.DataSource = databaseConnector.selectCalibratedChambers();
        }

        private void btnStartMeasurement_Click(object sender, EventArgs e)
        {
            try
            {
                string serialPort = getSerialPortFromDataGridView();

                if (!serialPortValidator.portExists(serialPort))
                {
                    throw new Exception("Port " + serialPort + " does not exists!");
                }

                measInfo = measurementInfoControl.getMeasurementInfo();
                databaseConnector.saveMeasurementInfo(measInfo);

                MeasurementForm measurementForm = new MeasurementForm(serialPort, measInfo);
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
                return "COM3";
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

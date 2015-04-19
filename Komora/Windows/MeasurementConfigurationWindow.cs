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

        public MeasurementConfigurationWindow()
        {
            InitializeComponent();

            databaseConnector = new Classes.DataBase.LinqDataBaseConnector();
            databaseConnector.connect();

            dgvChambers.DataSource = databaseConnector.selectCalibratedChambers();
        }

        private void btnStartMeasurement_Click(object sender, EventArgs e)
        {
            string serialPort = "COM3";

            try
            {
                MeasurementForm measurementForm = new MeasurementForm(serialPort);
                measurementForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

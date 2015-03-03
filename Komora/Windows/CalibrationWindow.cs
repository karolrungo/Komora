using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Classes.DataBase;
using System.IO;
using ZedGraph;

namespace Komora.Windows
{
    public partial class CalibrationWindow : Form
    {
        private IDataBaseConnector linqDatabaseConnector;
        private Classes.File.MeasurementSamplesReader<double> csvReader;
        private DataTypes.MeasurementSamples<double> measurementSamples;

        public CalibrationWindow()
        {
            linqDatabaseConnector = new LinqDataBaseConnector();
            linqDatabaseConnector.connect();

            InitializeComponent();

            textBoxFile.Text = "D:\\INŻYNIERKA\\IZNYNIERKA- wszystko\\pt100.csv";
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();

            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
	        {
                textBoxFile.Text = fileDialog.FileName;
	       }
        }

        private void buttonBeginCalibration_Click(object sender, EventArgs e)
        {
            try
            {
                csvReader = new Classes.File.MeasurementSamplesReader<double>();
                measurementSamples = new DataTypes.MeasurementSamples<double>();
                measurementSamples = csvReader.readSamplesFromFile(textBoxFile.Text);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}

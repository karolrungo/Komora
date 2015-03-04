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
using Komora;
using System.IO;
using ZedGraph;

namespace Komora.Windows
{
    public partial class CalibrationWindow : Form
    {
        private IDataBaseConnector linqDatabaseConnector;
        private Classes.File.MeasurementSamplesReader<double> csvReader;
        private DataTypes.MeasurementSamples<double> measurementSamples;
        DataTypes.Pt100Polynomial pt100Polynomial;

        public CalibrationWindow()
        {
            linqDatabaseConnector = new LinqDataBaseConnector();
            linqDatabaseConnector.connect();
            csvReader = new Classes.File.MeasurementSamplesReader<double>(); 
            measurementSamples = new DataTypes.MeasurementSamples<double>();
            pt100Polynomial = new DataTypes.Pt100Polynomial();

            InitializeComponent();

            textBoxFilePt100.Text = "D:\\INŻYNIERKA\\IZNYNIERKA- wszystko\\pt100.csv";
            dataGridViewPt100Chambers.DataSource = linqDatabaseConnector.selectAllChambers();
            dataGridViewPt100Polynomial.DataSource = linqDatabaseConnector.selectAllPt100Polynomials();
        }

        private void buttonBrowseFilePt100_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();

            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBoxFilePt100.Text = fileDialog.FileName;
            }
        }

        private void buttonBeginCalibrationPt100_Click(object sender, EventArgs e)
        {
            try
            {
                measurementSamples = csvReader.readSamplesFromFile(textBoxFilePt100.Text);                
                pt100Polynomial.calculateCoefficients(measurementSamples, 2);
                MessageBox.Show(pt100Polynomial.ToString());

            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

    }
}

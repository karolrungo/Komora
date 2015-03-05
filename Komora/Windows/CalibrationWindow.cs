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
        private IDataBaseConnector databaseConnector;
        private Classes.File.ISamplesReader<double> csvReader;
        private DataTypes.MeasurementSamples<double> measurementSamples;
        private DataTypes.Pt100Polynomial pt100Polynomial;
        private DataTypes.LedPolynomial ledPolynomial;

        public CalibrationWindow(IDataBaseConnector databaseConnector, Classes.File.ISamplesReader<double> csvReader)
        {
            this.databaseConnector = databaseConnector;
            this.csvReader = csvReader;

            this.databaseConnector.connect();

            measurementSamples = new DataTypes.MeasurementSamples<double>();

            InitializeComponent();

            calibrationControl1.setFilename("D:\\INŻYNIERKA\\IZNYNIERKA- wszystko\\pt100.csv");
            calibrationControl1.setPlotTitles("PT100 Calibration", "resistance?", "temperature?");
            //dataGridViewPt100Chambers.DataSource = linqDatabaseConnector.selectAllChambers();
            //dataGridViewPt100Polynomial.DataSource = linqDatabaseConnector.selectAllPt100Polynomials();
        }

        public CalibrationWindow()
        { }

 

            //    try
            //{
            //    measurementSamples = csvReader.readSamplesFromFile(textBoxFilePt100.Text);                
            //    pt100Polynomial.calculateCoefficients(measurementSamples, 2);
            //    MessageBox.Show(pt100Polynomial.ToString());

            //}
            //catch (Exception)
            //{
            //    throw new NotImplementedException();
            //}


    }
}

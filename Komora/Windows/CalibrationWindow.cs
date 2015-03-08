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

        public CalibrationWindow()
        { }

        public CalibrationWindow(IDataBaseConnector databaseConnector, Classes.File.ISamplesReader<double> csvReader)
        {
            this.databaseConnector = databaseConnector;
            this.csvReader = csvReader;

            this.databaseConnector.connect();

            measurementSamples = new DataTypes.MeasurementSamples<double>();

            calibrationControl1 = new Komora.Controls.CalibrationControl(Utilities.CoefficientsType.PT100);
            InitializeComponent();

            calibrationControl1.setFilename("D:\\INŻYNIERKA\\IZNYNIERKA- wszystko\\pt100.csv");
            calibrationControl1.setPlotTitles("PT100 Calibration", "resistance?", "temperature?");
            calibrationControl1.fillChamberDgv(databaseConnector.selectAllChambers());
            calibrationControl1.fillPolynomialDgv<Pt100_Poly>(databaseConnector.selectAllPt100Polynomials());

            calibrationControl1.DeleteCoefficientsButtonClicked += calibrationControl1_deleteCoefficientsButtonClicked;
        }

        private void calibrationControl1_deleteCoefficientsButtonClicked(object sender, Utilities.DeleteCoefficientsEventArgs e)
        {
            ;
            if (e.coefficientsType == Utilities.CoefficientsType.PT100)
            {
                MessageBox.Show("pt100");
                databaseConnector.deletePt100Coefficients(e.coefficientsID);
                calibrationControl1.fillPolynomialDgv<Pt100_Poly>(databaseConnector.selectAllPt100Polynomials());
            }
            else
            {
                MessageBox.Show("led");
            }
            
        }

        

 

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

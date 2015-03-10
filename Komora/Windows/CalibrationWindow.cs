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

            
            InitializeComponent();

            calibrationControlPt100.setCoefficientsType(Utilities.CoefficientsType.PT100);
            calibrationControlPt100.setFilename("D:\\INŻYNIERKA\\IZNYNIERKA- wszystko\\pt100.csv");
            calibrationControlPt100.setPlotTitles("PT100 Calibration", "resistance?", "temperature?");
            calibrationControlPt100.fillChamberDgv(databaseConnector.selectAllChambers());
            calibrationControlPt100.fillPolynomialDgv<Pt100_Poly>(databaseConnector.selectAllPt100Polynomials());

            calibrationControlPt100.DeleteSelectedCoefficientsButtonClicked += calibrationControl_deleteCoefficientsButtonClicked_PT100;
            calibrationControlPt100.DeleteAllCoefficientsButtonClicked += calibrationControlDeleteAllCoefficientsButtonClicked;
        }

        private void calibrationControlDeleteAllCoefficientsButtonClicked(object sender, Utilities.DeleteCoefficientsEventArgs e)
        {
            if (e.coefficientsType == Utilities.CoefficientsType.PT100)
            {
                databaseConnector.deletePt100Coefficients();
                calibrationControlPt100.fillPolynomialDgv<Pt100_Poly>(databaseConnector.selectAllPt100Polynomials());
            }
            else if (e.coefficientsType == Utilities.CoefficientsType.LED)
            {
                databaseConnector.deleteLedCoefficients();
                calibrationControlPt100.fillPolynomialDgv<Led_Poly>(databaseConnector.selectAllLedPolynomials());
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void calibrationControl_deleteCoefficientsButtonClicked_PT100(object sender, Utilities.DeleteCoefficientsEventArgs e)
        {
            if (e.coefficientsType == Utilities.CoefficientsType.PT100)
            {
                databaseConnector.deletePt100Coefficients(e.coefficientsID);
                calibrationControlPt100.fillPolynomialDgv<Pt100_Poly>(databaseConnector.selectAllPt100Polynomials());
            }
            else
            {
                MessageBox.Show("Error!");
            } 
        }
        private void calibrationControl_deleteCoefficientsButtonClicked_LED(object sender, Utilities.DeleteCoefficientsEventArgs e)
        {
            if (e.coefficientsType == Utilities.CoefficientsType.LED)
            {
                databaseConnector.deleteLedCoefficients(e.coefficientsID);
                calibrationControlPt100.fillPolynomialDgv<Led_Poly>(databaseConnector.selectAllLedPolynomials());
            }
            else
            {
                MessageBox.Show("Error!");
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

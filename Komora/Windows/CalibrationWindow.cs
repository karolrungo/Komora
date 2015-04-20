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
            pt100Polynomial = new DataTypes.Pt100Polynomial();
            ledPolynomial = new DataTypes.LedPolynomial();

            InitializeComponent();

            calibrationControlPt100.setCoefficientsType(Utilities.CoefficientsType.PT100);
            calibrationControlPt100.setFilename("D:\\INŻYNIERKA\\IZNYNIERKA- wszystko\\pt100.csv");
            calibrationControlPt100.setPlotTitles("PT100 Calibration", "Resistance [Ohm]", "Temperature [oC]");
            calibrationControlPt100.fillChamberDgv(databaseConnector.selectAllChambers());
            calibrationControlPt100.fillPolynomialDgv<Pt100_Poly>(databaseConnector.selectAllPt100Polynomials());

            calibrationControlPt100.DeleteSelectedCoefficientsButtonClicked += calibrationControl_deleteCoefficientsButtonClicked_PT100;
            calibrationControlPt100.DeleteAllCoefficientsButtonClicked += calibrationControl_DeleteAllCoefficientsButtonClicked;
            calibrationControlPt100.BeginCalibrationButtonClicked += calibrationControl_BeginCalibrationButtonClicked;
            calibrationControlPt100.SaveCoefficientsButtonClicked +=calibrationControl_SaveCoefficientsButtonClicked;

            calibrationControlLED.setCoefficientsType(Utilities.CoefficientsType.LED);
            calibrationControlLED.setFilename("D:\\INŻYNIERKA\\IZNYNIERKA- wszystko\\led.csv");
            calibrationControlLED.setPlotTitles("LED Calibration", "Current [mA]", "Power [mW]");
            calibrationControlLED.fillChamberDgv(databaseConnector.selectAllChambers());
            calibrationControlLED.fillPolynomialDgv<Led_Poly>(databaseConnector.selectAllLedPolynomials());

            calibrationControlLED.DeleteSelectedCoefficientsButtonClicked += calibrationControl_deleteCoefficientsButtonClicked_LED;
            calibrationControlLED.DeleteAllCoefficientsButtonClicked += calibrationControl_DeleteAllCoefficientsButtonClicked;
            calibrationControlLED.BeginCalibrationButtonClicked += calibrationControl_BeginCalibrationButtonClicked;
            calibrationControlLED.SaveCoefficientsButtonClicked += calibrationControl_SaveCoefficientsButtonClicked;
        }

        private void calibrationControl_SaveCoefficientsButtonClicked(object sender, Utilities.SaveCoefficientsEventArgs e)
        {
            try
            {
                if (e.coefficientsType == Utilities.CoefficientsType.PT100)
                {
                    databaseConnector.savePt100Coefficients(e.chamberID, pt100Polynomial.ToString());
                    calibrationControlPt100.fillPolynomialDgv<Pt100_Poly>(databaseConnector.selectAllPt100Polynomials());
                }
                else if (e.coefficientsType == Utilities.CoefficientsType.LED)
                {
                    databaseConnector.saveLEDCoefficients(e.chamberID,
                                                          ledPolynomial.lowerCurrentPolynmialString(),
                                                          ledPolynomial.higherCurrentPolynmialString());
                    calibrationControlLED.fillPolynomialDgv<Led_Poly>(databaseConnector.selectAllLedPolynomials());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void calibrationControl_BeginCalibrationButtonClicked(object sender, Utilities.DeleteCoefficientsEventArgs e)
        {
            try
            {
                if (e.coefficientsType == Utilities.CoefficientsType.PT100)
                {
                    measurementSamples = csvReader.readSamplesFromFile(calibrationControlPt100.getFilename());
                    pt100Polynomial.calculateCoefficients(measurementSamples, calibrationControlPt100.getPolynomialOrderPt100());
                    calibrationControlPt100.showResults(pt100Polynomial.ToString());
                    calibrationControlPt100.clearGraph();
                    calibrationControlPt100.drawMeasurementSamplesOnGraph(measurementSamples.samples, "samples from file");
                    calibrationControlPt100.drawApproximationResultOnGraph(measurementSamples.samples, 
                                                                           pt100Polynomial,
                                                                           "approximation result");                }
                else if (e.coefficientsType == Utilities.CoefficientsType.LED)
                {
                    int lowerPolyOrder = calibrationControlLED.getPolynomialOrderLower();
                    int higherPolyOrder = calibrationControlLED.getPolynomialOrderHigher();
                    int currentBound = calibrationControlLED.getCurrentBound();

                    measurementSamples = csvReader.readSamplesFromFile(calibrationControlLED.getFilename());
                    ledPolynomial.calculateCoefficients(measurementSamples, currentBound, lowerPolyOrder, higherPolyOrder);
                    calibrationControlLED.showResults(ledPolynomial.lowerCurrentPolynmialString().ToString(),
                                                      ledPolynomial.higherCurrentPolynmialString().ToString());
                    calibrationControlLED.clearGraph();
                    calibrationControlLED.drawMeasurementSamplesOnGraph(measurementSamples.samples, "samples from file");
                    calibrationControlLED.drawApproximationResultOnGraph(measurementSamples.samples,
                                                                         ledPolynomial,
                                                                         "approximation result");  
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }   
        }
        private void calibrationControl_DeleteAllCoefficientsButtonClicked(object sender, Utilities.DeleteCoefficientsEventArgs e)
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
    }
}

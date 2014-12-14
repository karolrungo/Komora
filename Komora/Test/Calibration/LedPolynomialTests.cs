using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Komora.Test.Calibration
{
    //2 rzazy wola funkcje
    [TestFixture]
    public class LedPolynomialTests
    {
        Komora.DataTypes.LedPolynomial ledPoly;

        [SetUp]
        public void setUp()
        {
            ledPoly = new Komora.DataTypes.LedPolynomial();
        }

        [Test]
        public void DeviceCalibratorReturnsProperCoefficientsForSimpleSquarePolynomial()
        {
            ledPoly = new Komora.DataTypes.LedPolynomial();
            Komora.DataTypes.MeasurementSamples<double> samples = new Komora.DataTypes.MeasurementSamples<double>(new List<Tuple<double, double>> 
                                                               {
                                                                   new Tuple<double,double>(0.0, 0.0),
                                                                   new Tuple<double,double>(2.0, 4.0),
                                                                   new Tuple<double,double>(3.0, 9.0),
                                                                   new Tuple<double,double>(5.0, 125.0),
                                                                   new Tuple<double,double>(6.0, 216.0),
                                                                   new Tuple<double,double>(10.0, 1000.0),
                                                                   new Tuple<double,double>(20.0, 8000.0)
                                                               });
            var resultLowerCurrent  = new Komora.DataTypes.PolynomialCoefficients<double>(new List<double>() { 0.0, 0.0, 1.0 });
            var resultHigherCurrent = new Komora.DataTypes.PolynomialCoefficients<double>(new List<double>() { 0.0, 0.0, 0.0, 1.0 });
            int lowerOrder = 2;
            int higherOrder = 3;
            int bound = 4;

            ledPoly.calculateCoefficients(samples, bound, lowerOrder, higherOrder);

            Assert.That(resultLowerCurrent,  Is.EqualTo(ledPoly.getLowerCurrentPolynomialCoefficients()).Within(.001));
            Assert.That(resultHigherCurrent, Is.EqualTo(ledPoly.getHigherCurrentPolynomialCoefficients()).Within(.001));
        }

        //DeviceCalibrator<double>.calculatePolynomialCoefficients(dividedSamples
        //[Test]
        //public void calculateCoefficientsMethodCallsDeviceCalculatorCalculatePolynomialCoefficientsExactlyTwoTimes()
        //{
 
        //}
    }
}

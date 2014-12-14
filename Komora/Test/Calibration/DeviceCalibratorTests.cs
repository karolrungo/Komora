using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Komora.Test.Calibration
{
    [TestFixture]
    public class DeviceCalibratorTests
    {
        Komora.DataTypes.PolynomialCoefficients<double> coefficients;
        [Test]
        public void DeviceCalibratorReturnsProperCoefficientsForSimpleSquarePolynomial()
        {      
            Komora.DataTypes.MeasurementSamples<double> samples = new Komora.DataTypes.MeasurementSamples<double> (new List<Tuple<double,double>> 
                                                               {
                                                                   new Tuple<double,double>(0.0, 0.0),
                                                                   new Tuple<double,double>(2.0, 4.0),
                                                                   new Tuple<double,double>(3.0, 9.0)
                                                               });
            var result = new Komora.DataTypes.PolynomialCoefficients<double>(new List<double>() { 0.0, 0.0, 1.0 });
            int order = 2;

            coefficients = Classes.Calibration.DeviceCalibrator.calculatePolynomialCoefficients(samples, order);

            Assert.That( result, Is.EqualTo( coefficients ).Within( .001 ));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.Interpolation;

namespace Komora.Classes.Calibration
{
    public static class DeviceCalibrator
    {
        public static DataTypes.PolynomialCoefficients<double> calculatePolynomialCoefficients(DataTypes.MeasurementSamples<double> samples, int degree)
        {
            DataTypes.PolynomialCoefficients<double> coefficients = new DataTypes.PolynomialCoefficients<double>();
            
            var X = samples.getSamples().Select( c=>c.Item1).ToArray();
            var Y = samples.getSamples().Select( c=>c.Item2).ToArray();
            coefficients.setCoefficients(MathNet.Numerics.Fit.Polynomial(X, Y, degree).ToList());

            return coefficients;
        }
    }
}

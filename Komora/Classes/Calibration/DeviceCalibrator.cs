using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.Interpolation;

namespace Komora.Classes.Calibration
{
    public static class DeviceCalibrator<T>
    {
        public static DataTypes.PolynomialCoefficients<double> calculatePolynomialCoefficients(DataTypes.MeasurementSamples<T> samples, int degree)
        {
            if( typeof(T) == typeof(double) )
            {
                DataTypes.PolynomialCoefficients<double> coefficients = new DataTypes.PolynomialCoefficients<double>();
            
                double[] X = samples.samples.Select( c=>Convert.ToDouble(c.Item1)).ToArray();
                double[] Y = samples.samples.Select( c=>Convert.ToDouble(c.Item2)).ToArray();
                coefficients.setCoefficients(MathNet.Numerics.Fit.Polynomial(X, Y, degree).ToList());

                return coefficients;
            }
            else
            {
                throw new NotSupportedException("Polynomial.Fit: T type must be double.");
            }
        }
    }
}

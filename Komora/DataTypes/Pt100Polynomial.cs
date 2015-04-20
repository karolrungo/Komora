using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.DataTypes
{
    public class Pt100Polynomial: IFormattable
    {
        PolynomialCoefficients<double> polynomial;
        public Pt100Polynomial()
        {
            this.polynomial = new PolynomialCoefficients<double>();
        }

        public void setCoefficients(PolynomialCoefficients<double> source)
        {
            this.polynomial = source;
        }

        public void calculateCoefficients(DataTypes.MeasurementSamples<double> samples, int degree)
        {
            try
            {
                polynomial = Komora.Classes.Calibration.DeviceCalibrator<double>.calculatePolynomialCoefficients(samples, degree);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override string ToString()
        {
            return polynomial.ToString();
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        internal List<double> getCoefficients()
        {
            return polynomial.getCoefficients();
        }
    }
}

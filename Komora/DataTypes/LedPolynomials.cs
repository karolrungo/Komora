using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.DataTypes
{
    public class LedPolynomials
    {
        PolynomialCoefficients<double> lowerCurrent;
        PolynomialCoefficients<double> higherCurrent;
        DataTypes.MeasurementSamples<double>[] dividedSamples;
        enum CurrentType {Lower = 0, Higher };

        public LedPolynomials()
        {
            this.lowerCurrent  = new PolynomialCoefficients<double>();
            this.higherCurrent = new PolynomialCoefficients<double>();
            dividedSamples = new MeasurementSamples<double>[2];
        }

        public void setCoefficients(PolynomialCoefficients<double> lowerCurrent, PolynomialCoefficients<double> higherCurrent)
        {
            this.lowerCurrent = lowerCurrent;
            this.higherCurrent = higherCurrent;
        }

        public void calculateCoefficients(DataTypes.MeasurementSamples<double> samples, double bound, int lowerCurrentPolyOrder, int higherCurrentPolyOrder)
        {
            divideSamples(samples, bound);
            try
            {
                lowerCurrent  = Classes.Calibration.DeviceCalibrator<double>.calculatePolynomialCoefficients(dividedSamples[(int)CurrentType.Lower], lowerCurrentPolyOrder);
                higherCurrent = Classes.Calibration.DeviceCalibrator<double>.calculatePolynomialCoefficients(dividedSamples[(int)CurrentType.Higher], higherCurrentPolyOrder);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void divideSamples(DataTypes.MeasurementSamples<double> samples, double bound)
        {
            foreach (Tuple<double, double> sample in samples.samples)
            {
                if (sample.Item1 <= bound)
                {
                    dividedSamples[(int)CurrentType.Lower].samples.Add(sample);
                }
                else
                {
                    dividedSamples[(int)CurrentType.Higher].samples.Add(sample);
                }
            }
        }
    }
}

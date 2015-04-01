using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komora.Classes;
using MathNet.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace Komora.Utilities
{
    public class Pt100converter
    {
        List<double> coefficients;
        public List<double> Coefficients { get { return coefficients; } }
        string coefficientsString;
        readonly int scaler;
        
        public Pt100converter(string coefficientsString, int scaler)
        {
            this.scaler = scaler;
            coefficients = new List<double>();
            this.coefficientsString = coefficientsString;
            getCoefficients();
        }

        public void getCoefficients()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            char separator = ':';
            string[] splitted = coefficientsString.Split(separator);
    
            foreach (string coefficient in splitted)
            {
                coefficients.Add(Double.Parse(coefficient));
            }
        }

        public long temperatureToResistance(double temperature)
        {
            double result = 0;

            for (int i = 0; i < coefficients.Count; i++)
            {
                double a = Math.Pow(temperature, double.Parse(i.ToString()));
                result += coefficients[i] * a;
            }
            return Convert.ToInt64(result*scaler);
        }

        public double resistanceToTemperature(long resistance)
        {
            resistance = resistance / scaler;

            coefficients[0] -= resistance;

            Func<double, double> f = x => Evaluate.Polynomial(x, coefficients.ToArray());
            double result = FindRoots.OfFunction(f, 0, 225000);

            coefficients[0] += resistance;

            return result;
        }

    }
}

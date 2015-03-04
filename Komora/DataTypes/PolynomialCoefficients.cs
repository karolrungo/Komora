using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komora.DataTypes
{
    public class PolynomialCoefficients<T> : IEnumerable<T>
    {
        private List<T> coefficients;

        public PolynomialCoefficients()
        {
            this.coefficients = new List<T>();
        }

        public PolynomialCoefficients(List<T> source)
        {
            this.coefficients = source;
        }

        public int Degree 
        {
            get { return coefficients.Count - 1; } 
        }

        public void setCoefficients(List<T> source)
        {
            coefficients.Clear();
            foreach (T coefficient in source)
            {
                coefficients.Add(coefficient);
            }
        }

        public List<T> getCoefficients()
        {
            return coefficients;
        }

        public void reset()
        {
            coefficients.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return coefficients.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public string ToString()
        {
            string format = "{0:f4}";
            StringBuilder polynomialString = new StringBuilder();
            char separator = ':';

            foreach (T coefficient in coefficients)
            {
                polynomialString.AppendFormat("{0}{1}", String.Format(format, coefficient), separator);
            }
            polynomialString.Remove(polynomialString.Length - 1, 1); //usuwa separator z konca stringa
            return polynomialString.ToString();
            
        }
    }
}

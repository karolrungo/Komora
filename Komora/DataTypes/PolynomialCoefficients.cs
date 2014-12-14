using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

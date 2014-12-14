using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public class Pt100Polynomial<T>
    {
        PolynomialCoefficients<T> polynomial;
        public Pt100Polynomial()
        {
            this.polynomial = new PolynomialCoefficients<T>();
        }
    }
}

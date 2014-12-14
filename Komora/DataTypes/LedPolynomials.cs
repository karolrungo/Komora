using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public class LedPolynomials<T>
    {
        PolynomialCoefficients<T> lowerCurrent;
        PolynomialCoefficients<T> higherCurrent;
        public LedPolynomials()
        {
            this.lowerCurrent = new PolynomialCoefficients<T>();
            this.higherCurrent = new PolynomialCoefficients<T>();
        }
    }
}

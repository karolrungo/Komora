using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Komora.DataTypes;
using System.Threading;

namespace Komora.Test.Calibration
{
    [TestFixture]
    public class Pt100PolynomialTests
    {
        private Pt100Polynomial pt100poly;

        [Test]
        public void toStringReturnsProperString()
        {
            PolynomialCoefficients<double> coefficients = new PolynomialCoefficients<double>(new List<double>() { 1.0, 2.0, 3.0, 4.0 });
            pt100poly = new Pt100Polynomial();

            pt100poly.setCoefficients(coefficients);
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            Assert.That("1.0000:2.0000:3.0000:4.0000", Is.EqualTo(pt100poly.ToString()));
        }
    }
}

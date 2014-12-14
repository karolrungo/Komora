using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Komora.Test.DataTypes
{
    [TestFixture]
    public class PolynomialCoefficientsTests
    {
        Komora.DataTypes.PolynomialCoefficients<double> polynomial;

        [Test]
        public void canCreatePolynomialCoefficients()
        {
            polynomial = new Komora.DataTypes.PolynomialCoefficients<double>(
                                                            new List<double>() { 1, 2, 3, 4, 5 }
                                                            );

            Assert.AreEqual(new List<double>() { 1, 2, 3, 4, 5 }, polynomial.getCoefficients());
            Assert.AreEqual(4, polynomial.Degree);
        }

        [Test]
        public void setCoefficientsSetsProperValueToList()
        {
            polynomial = new Komora.DataTypes.PolynomialCoefficients<double>();

            polynomial.setCoefficients(new List<double>() { 1, 2, 3, 4, 5 });

            Assert.AreEqual(new List<double>() { 1, 2, 3, 4, 5 }, polynomial.getCoefficients());
            Assert.AreEqual(4, polynomial.Degree);
        }

    }
}

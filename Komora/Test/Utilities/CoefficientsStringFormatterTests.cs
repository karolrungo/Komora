using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Komora.Test.Utilities
{
    [TestFixture]
    public class CoefficientsStringFormatterTests
    {
        [Test]
        public void getRevertedListOfCoefficientsReturnsRevertedList()
        {
            string inputString = "100:0.38:0.01";
            Komora.Utilities.CoefficientsStringFormatter formatter = new Komora.Utilities.CoefficientsStringFormatter(inputString);

            List<string> expectedResult = new List<string>() {"0.01", "0.38", "100"};

            Assert.AreEqual(expectedResult, formatter.getRevertedListOfCoefficients());
        }

        [Test]
        public void formatStringReturnsGoodString()
        {
            string inputString = "100:0.38:0.01";
            Komora.Utilities.CoefficientsStringFormatter formatter = new Komora.Utilities.CoefficientsStringFormatter(inputString);

            string expectedResult = "0.01x^2 + 0.38x + 100";

            Assert.AreEqual(expectedResult, formatter.formatString());
        }
    }
}

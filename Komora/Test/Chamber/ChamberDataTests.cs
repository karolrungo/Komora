using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Komora.Classes.Chamber;

namespace Komora.Test.Chamber
{
    [TestFixture]
    class ChamberDataTests
    {
        [Test]
        public void numberPropertyThrowsExceptionWhenCanNotParseStringToInt()
        {
            ChamberData chamberData = new ChamberData();
            string numberString = "not number string";

            Assert.Throws(typeof(FormatException),
                           delegate { chamberData.Number = Int32.Parse(numberString); });
        }
    }
}

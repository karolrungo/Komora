using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace Komora.Test
{
    [TestFixture]
    public class DataBaseConnectionProxyTests
    {
        [TestCase]
        public void BasicTest()
        {
            Assert.AreEqual(1, 1);
        }
        //private Mock<Komora.DataBase.LinqDataBaseConnector> DataBaseConnectorMock = new Mock<Komora.DataBase.LinqDataBaseConnector>();
    }
}

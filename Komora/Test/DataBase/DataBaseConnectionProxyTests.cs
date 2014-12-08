using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Komora.Classes.DataBase;


namespace Komora.Test.DataBase
{
    [TestFixture]
    public class DataBaseConnectionProxyTests
    {
        [Test]
        public void getUserGetsUserByIDFromDataBaseAfterEstablishingConnectionToDatabase()
        {
            var dataBaseConnectorMock = new Mock<IDataBaseConnector>();
            //dataBaseConnectorMock.Setup(m => m.Connect()).Returns(true);

            IDataBaseConncection dataBaseConnection = new DataBaseConnectionProxy(dataBaseConnectorMock.Object);
            Assert.AreEqual(new Object(), dataBaseConnection.getUser(5));
        }
    }
}

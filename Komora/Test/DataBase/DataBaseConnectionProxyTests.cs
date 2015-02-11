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
        private Mock<IDataBaseConnector> dataBaseConnectorMock;

        [SetUp]
        public void Init()
        {
            dataBaseConnectorMock = new Mock<IDataBaseConnector>();
        }

        [Test]
        public void constructorTriesToEstablishConnectionToDatabaseOnlyOneTime()
        {
            dataBaseConnectorMock.Setup(x => x.connect()).Returns(true);

            DataBaseConnectionProxy dbConnection = new DataBaseConnectionProxy(dataBaseConnectorMock.Object);

            dataBaseConnectorMock.Verify(m => m.connect(), Times.Exactly(1));
        }

        [Test]
        public void constructorThrowsExceptionWhenEstablishingConnectionFails()
        {
            dataBaseConnectorMock.Setup(x => x.connect()).Returns(false);

            Assert.Throws(typeof(DatabaseConnectionException),
                         delegate { new DataBaseConnectionProxy(dataBaseConnectorMock.Object); });
        }

        [Test]
        public void destructorThrowsExceptionWhenDeletingConnectionFails()
        {
            dataBaseConnectorMock.Setup(x => x.disconnect()).Returns(false);

            Assert.Throws(typeof(DatabaseConnectionException),
                         delegate { new DataBaseConnectionProxy(dataBaseConnectorMock.Object); });
        }

        [Test]
        public void destructorDoenNotThrowExceptionWhenDeletingConnectionSuccess()
        {
            dataBaseConnectorMock.Setup(x => x.connect()).Returns(true);
            dataBaseConnectorMock.Setup(x => x.disconnect()).Returns(true);

            Assert.DoesNotThrow(delegate { new DataBaseConnectionProxy(dataBaseConnectorMock.Object); });

        }
    }
}

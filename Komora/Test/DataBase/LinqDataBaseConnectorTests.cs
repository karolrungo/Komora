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
    class LinqDataBaseConnectorTests
    {
        [Test]
        public void canConnectToDatabase()
        {
            LinqDataBaseConnector linqDatabaseConnector = new LinqDataBaseConnector();
            Assert.True(linqDatabaseConnector.connect());
        }

        [Test]
        public void cannotDisconnectFromDatabaseWithoutEstablishingConnectionFirst()
        {
            LinqDataBaseConnector linqDatabaseConnector = new LinqDataBaseConnector();
            Assert.False(linqDatabaseConnector.disconnect());
        }

        [Test]
        public void canDisconnectFromDatabaseAfterEstablishingConnectionFirst()
        {
            LinqDataBaseConnector linqDatabaseConnector = new LinqDataBaseConnector();
            linqDatabaseConnector.connect();
            Assert.True(linqDatabaseConnector.disconnect());
        }

        [Test]
        public void canReconnectToDatabaseAfterDisconnection()
        {
            LinqDataBaseConnector linqDatabaseConnector = new LinqDataBaseConnector();
            linqDatabaseConnector.connect();
            linqDatabaseConnector.disconnect();
            Assert.True(linqDatabaseConnector.connect());
        }
    }
}

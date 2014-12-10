using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using Moq;
using Komora;

namespace Komora.Test.Loger
{
    [TestFixture]
    public class LogerDataBaseTests
    {
        private Mock<Classes.DataBase.IDataBaseConncection> dataBaseConnectionMock;
        private Classes.Loger.LogerDataBase logerDatabase;

        [SetUp]
        public void Init()
        {
            dataBaseConnectionMock = new Mock<Classes.DataBase.IDataBaseConncection>();
            logerDatabase = new Classes.Loger.LogerDataBase(dataBaseConnectionMock.Object);
        }

        [Test]
        public void ValidateUserFunctionsCallsgetUserByCredentialsExactlyOnceShouldPass()
        {
            dataBaseConnectionMock.Setup(m => m.getUserByCredentials(It.IsAny<string>(), It.IsAny<string>())).Returns(new object());

            logerDatabase.validateUser("user", "pass");

            dataBaseConnectionMock.Verify(m => m.getUserByCredentials(It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void ValidateUserCalledWithGoodUserCredentialsRaisesLoginSuccesEventShouldPass()
        {
            dataBaseConnectionMock.Setup(m => m.getUserByCredentials(It.IsAny<string>(), It.IsAny<string>())).Returns(new object());
            logerDatabase = new Classes.Loger.LogerDataBase(dataBaseConnectionMock.Object);

            logerDatabase.validateUser("user", "pass"); //czy ta metoda wywola eventa - jak to sprawdzic

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using Moq;
using Komora;
using Komora.Classes.DataBase;

namespace Komora.Test.Loger
{
    [TestFixture]
    public class LogerDataBaseTests
    {
        private Mock<Classes.DataBase.IDataBaseConnector> dataBaseConnectorMock;
        private Classes.Loger.LogerDataBase logerDatabase;

        [SetUp]
        public void Init()
        {
            dataBaseConnectorMock = new Mock<Classes.DataBase.IDataBaseConnector>();
            logerDatabase = new Classes.Loger.LogerDataBase(dataBaseConnectorMock.Object);
        }

        [Test]
        public void ValidateUserFunctionsCallsgetUserByCredentialsExactlyOnceShouldPass()
        {
            logerDatabase.validateUser("user", "pass");

            dataBaseConnectorMock.Verify(m => m.getUser(It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void ValidateUserCalledWithGoodUserCredentialsRaisesLoginSuccesEventShouldPass()
        {
            dataBaseConnectorMock.Setup(m => m.getUser(It.IsAny<string>(), It.IsAny<string>())).Returns(new User());

            var wasRaised = false;
            logerDatabase.loginSucces += (object sender, EventArgs e) => wasRaised = true;

            logerDatabase.validateUser("user", "pass"); 

            Assert.IsTrue(wasRaised);
        }

        [Test]
        public void ValidateUserCalledWithWrongUserCredentialsRaisesLoginFailedEventShouldPass()
        {
            dataBaseConnectorMock.Setup(m => m.getUser("user", "pass")).Throws(new Exception());

            var wasRaised = false;
            logerDatabase.loginFailed += (object sender, EventArgs e) => wasRaised = true;

            logerDatabase.validateUser("user", "pass");

            Assert.IsTrue(wasRaised);
        }

        [Test]
        public void ValidateUserCalledCallsProperEventForDifferentCredentials()
        {
            dataBaseConnectorMock.Setup(m => m.getUser("user", "pass")).Returns(new User());
            dataBaseConnectorMock.Setup(m => m.getUser("wrong", "credentials")).Throws(new Exception());

            var wasFailedRaised = false;
            var wasSuccessRaised = false;

            logerDatabase.loginFailed += (object sender, EventArgs e) => wasFailedRaised = true;
            logerDatabase.loginSucces += (object sender, EventArgs e) => wasSuccessRaised = true;

            logerDatabase.validateUser("wrong", "credentials");
            Assert.That(wasFailedRaised == true && wasSuccessRaised == false);
          
            logerDatabase.validateUser("user", "pass");
            Assert.True(wasSuccessRaised);
        }
    }
}

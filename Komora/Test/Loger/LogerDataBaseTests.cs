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
            logerDatabase.validateUser("user", "pass");

            dataBaseConnectionMock.Verify(m => m.getUserByCredentials(It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void ValidateUserCalledWithGoodUserCredentialsRaisesLoginSuccesEventShouldPass()
        {
            dataBaseConnectionMock.Setup(m => m.getUserByCredentials(It.IsAny<string>(), It.IsAny<string>())).Returns(new User());

            var wasRaised = false;
            logerDatabase.loginSucces += (object sender, EventArgs e) => wasRaised = true;

            logerDatabase.validateUser("user", "pass"); 

            Assert.IsTrue(wasRaised);
        }

        [Test]
        public void ValidateUserCalledWithWrongUserCredentialsRaisesLoginFailedEventShouldPass()
        {
            dataBaseConnectionMock.Setup(m => m.getUserByCredentials("user", "pass")).Throws(new Exception());

            var wasRaised = false;
            logerDatabase.loginFailed += (object sender, EventArgs e) => wasRaised = true;

            logerDatabase.validateUser("user", "pass");

            Assert.IsTrue(wasRaised);
        }

        [Test]
        public void ValidateUserCalledCallsProperEventForDifferentCredentials()
        {
            dataBaseConnectionMock.Setup(m => m.getUserByCredentials("user", "pass")).Returns(new User());
            dataBaseConnectionMock.Setup(m => m.getUserByCredentials("wrong", "credentials")).Throws(new Exception());

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

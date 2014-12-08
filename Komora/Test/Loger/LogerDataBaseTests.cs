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
    public class LogerDataBaseTests
    {
        [TestCase]
        public void ValidateUserCalledWithGoodUserCredentialsSetsValidationOkFlagONShouldPass()
        {
            var dataBaseConnectionMock = new Mock<Classes.DataBase.IDataBaseConncection>();
            dataBaseConnectionMock.Setup(m => m.getUserByCredentials(It.IsAny<string>(), It.IsAny<string>())).Returns(new object());

            var loger = new Classes.Loger.LogerDataBase(dataBaseConnectionMock.Object);
            loger.validateUser("user", "pass");

            Assert.AreEqual(true, loger.canLogIn());
        }
    }
}

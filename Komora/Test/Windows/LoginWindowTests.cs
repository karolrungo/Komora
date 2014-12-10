using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Komora;

namespace Komora.Test.Windows
{
    [TestFixture]
    public class LoginWindowTests
    {
        [TestCase]
        public void WhenUserCredentialsAreProperLogerShouldRaiseLoginSuccesEvent()
        {
            var logerMock = new Mock<Classes.Loger.Loger>();
            logerMock.Setup(m => m.validateUser(It.IsAny<string>(), It.IsAny<string>())).Raises(m => m.loginSucces += null, EventArgs.Empty);

            Komora.Windows.LoginWindow loginWindow = new 
        }
    }
}

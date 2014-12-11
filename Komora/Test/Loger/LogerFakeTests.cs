using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Komora.Test.Loger
{
    [TestFixture]
    public class LogerFakeTests
    {
        private Classes.Loger.LogerFake logerFake;

        [Test]
        public void ValidateUserAlwaysRaisesLoginSuccesEventAndNeverraisesLoginFailedEventShouldPass()
        {
            logerFake = new Classes.Loger.LogerFake();
            var wasEventSuccessRaised = false;
            var wasEventFailedRaised = false;

            logerFake.loginSucces += (object sender, EventArgs e) => wasEventSuccessRaised = true;
            logerFake.loginFailed += (object sender, EventArgs e) => wasEventFailedRaised = true;

            logerFake.validateUser("user", "pass");

            Assert.IsTrue(wasEventSuccessRaised);
            Assert.IsFalse(wasEventFailedRaised);
        }
    }
}

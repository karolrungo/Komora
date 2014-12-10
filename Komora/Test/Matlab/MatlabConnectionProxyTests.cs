using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace Komora.Test.Matlab
{
    [TestFixture]
    public class MatlabConnectionProxyTests
    {
        [Test]
        public void canCreateInstance()
        {
            var matlabConnectorMock = new Mock<Classes.Matlab.IMatlabConnector>();
            matlabConnectorMock.Setup(m => m.connect()).Returns(true);

            Classes.Matlab.MatlabConnectionProxy matlabConnection = new Classes.Matlab.MatlabConnectionProxy(matlabConnectorMock.Object);
        }
    }
}

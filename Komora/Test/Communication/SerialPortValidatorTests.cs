using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;

namespace Komora.Test.Communication
{
    [TestFixture]
    public class SerialPortValidatorTests
    {
        private Classes.Communication.SerialPortValidator sut;

        [TestCase("COM5", true)]
        [TestCase("COM55", true)]
        [TestCase("aCOM5", false)]
        [TestCase("COM5a", false)]
        [TestCase("aCOM5a", false)]
        [TestCase("WrongPortName_5", false)]
        [TestCase("COM_Wrong", false)]
        public void portHasValidNameRetrunsProperValue(string portName, bool expectedResult)
        {
            sut = new Classes.Communication.SerialPortValidator();

            Assert.AreEqual(expectedResult, sut.portHasValidName(portName));
        }
    }
}

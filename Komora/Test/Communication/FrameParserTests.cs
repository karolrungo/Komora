using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Komora.Classes.Communication;
using Komora.DataTypes;

namespace Komora.Test.Communication
{
    [TestFixture]
    public class FrameParserTests
    {
        [Test]
        public void asdf()
        {
            ControllerValues controllerValues = new ControllerValues();
            FrameParser sut = new FrameParser();

            string inputString = "+LCD_CONTR=5";

            sut.ParseInputString(inputString, ref controllerValues);

            Assert.AreEqual(5, controllerValues.lcd_Contr);
        }
    }
}

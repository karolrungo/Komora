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
        private ControllerValues controllerValues;
        private FrameParser sut;

        [SetUp]
        public void Init()
        {
            controllerValues = new ControllerValues();
            sut = new FrameParser();
        }

        [TestCase("+LCD_CONTR=5", 5)]
        [TestCase("+LCD_CONTR=WrongValue", Int32.MinValue)]
        public void lcdContrastFrameSetsProperValue(string inputFrame, int expectedResult)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.AreEqual(expectedResult, controllerValues.lcd_Contr);  
        }

        [TestCase("+LCD_BKT=1", true)]
        [TestCase("+LCD_BKT=0", false)]
        public void lcdBacklightFrameSetsProperValue(string inputFrame, bool expectedResult)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.AreEqual(expectedResult, controllerValues.lcd_Bkt); 
        }

        [TestCase("+CONT_MODE=IDLE", CONT_MODE.IDLE)]
        [TestCase("+CONT_MODE=FEEDBACK", CONT_MODE.FEEDBACK)]
        [TestCase("+CONT_MODE=OPEN", CONT_MODE.OPEN)]
        [TestCase("+CONT_MODE=ERROR", CONT_MODE.ERROR)]
        public void controllerModeFrameStetsProperValue(string inputFrame, CONT_MODE expectedResult)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.AreEqual(expectedResult, controllerValues.cont_Mode);
        }

        [TestCase("+CONTROL_MODE=BOTH", CONTROL_MODE.BOTH)]
        [TestCase("+CONTROL_MODE=HEATER", CONTROL_MODE.HEATER)]
        [TestCase("+CONTROL_MODE=DIODE", CONTROL_MODE.DIODE)]
        [TestCase("+CONTROL_MODE=OFF", CONTROL_MODE.OFF)]
        [TestCase("+CONTROL_MODE=ERROR", CONTROL_MODE.ERROR)]
        [TestCase("+CONTROL_MODE=WrongValue", CONTROL_MODE.ERROR)]
        public void pwmModeFrameStetsProperValue(string inputFrame, CONTROL_MODE expectedResult)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.AreEqual(expectedResult, controllerValues.pwm_Mode);
        }

        [TestCase("+DISPALY_MODE=INFO", DISPLAY_MODE.INFO)]
        [TestCase("+DISPALY_MODE=PT100_VOLT", DISPLAY_MODE.PT100_VOLT)]
        [TestCase("+DISPALY_MODE=PT100_PARAMS", DISPLAY_MODE.PT100_PARAMS)]
        [TestCase("+DISPALY_MODE=HEATER_PARAMS", DISPLAY_MODE.HEATER_PARAMS)]
        [TestCase("+DISPALY_MODE=DIODE_PARAMS", DISPLAY_MODE.DIODE_PARAMS)]
        [TestCase("+DISPALY_MODE=TIME", DISPLAY_MODE.TIME)]
        [TestCase("+DISPALY_MODE=ERROR", DISPLAY_MODE.ERROR)]
        [TestCase("+DISPALY_MODE=WrongValue", DISPLAY_MODE.ERROR)]
        public void displayModeFrameStetsProperValue(string inputFrame, DISPLAY_MODE expectedResult)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.AreEqual(expectedResult, controllerValues.display_Mode);
        }

        [TestCase("+TIME_DISPLAY_MODE=TIME", TIME_DISPLAY_MODE.TIME)]
        [TestCase("+TIME_DISPLAY_MODE=DATE", TIME_DISPLAY_MODE.DATE)]
        [TestCase("+TIME_DISPLAY_MODE=WEEKDAY", TIME_DISPLAY_MODE.WEEKDAY)]
        [TestCase("+TIME_DISPLAY_MODE=ERROR", TIME_DISPLAY_MODE.ERROR)]
        [TestCase("+TIME_DISPLAY_MODE=WrongValue", TIME_DISPLAY_MODE.ERROR)]
        public void displayModeFrameStetsProperValue(string inputFrame, TIME_DISPLAY_MODE expectedResult)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.AreEqual(expectedResult, controllerValues.time_Display_Mode);
        }

        [TestCase("+PID_HEATER_TUNES=WrongValue")]
        public void pidHeaterTunesFrameStetsProperValueForBadFrame(string inputFrame)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.True(new Tunes() == controllerValues.heater_Tunes);
        }

        [TestCase("+PID_HEATER_TUNES=1:2:3:100", 1, 2, 3, 100)]
        public void pidHeaterTunesFrameStetsProperValueForGoodFrame(string inputFrame, int kp, int ki, int kd, int scal)
        {
            Tunes expectedResult = new Tunes();
            expectedResult.kp = kp;
            expectedResult.ki = ki;
            expectedResult.kd = kd;
            expectedResult.scal = scal;

            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.True(expectedResult == controllerValues.heater_Tunes);
        }

        [TestCase("+PID_DIODE_TUNES=WrongValue")]
        public void pidDiodeTunesFrameStetsProperValueForBadFrame(string inputFrame)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.True(new Tunes() == controllerValues.heater_Tunes);
        }

        [TestCase("+PID_DIODE_TUNES=1:2:3:100", 1, 2, 3, 100)]
        public void pidDiodeTunesFrameStetsProperValueForGoodFrame(string inputFrame, int kp, int ki, int kd, int scal)
        {
            Tunes expectedResult = new Tunes();
            expectedResult.kp = kp;
            expectedResult.ki = ki;
            expectedResult.kd = kd;
            expectedResult.scal = scal;

            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.True(expectedResult == controllerValues.diode_Tunes);
        }

        [TestCase("+HEATER_CV=5", 5)]
        public void heaterCVFrameSetsProperValue(string inputFrame, int expectedResult)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.True(expectedResult == controllerValues.heater_Params.cv);
        }

        [TestCase("+HEATER_AUTO_DATA=1:2", 1)]
        public void heaterAutoDataSetsProperValueInOpenLoopMode(string inputFrame, int heaterPowerExpected)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.True(heaterPowerExpected == controllerValues.heater_Power);
        }

        [TestCase("+HEATER_AUTO_DATA=1:2:3:4:5:6", 1, 3 ,4, 5, 6)]
        public void heaterAutoDataSetsProperValueInFeedbackMode(string inputFrame,
                                                                int heaterPowerExpected,
                                                                int spExpected,
                                                                int cvExpected,
                                                                int pvExpected,
                                                                int errorExpected)
        {
            sut.ParseInputString(inputFrame, ref controllerValues);
            Assert.True(heaterPowerExpected == controllerValues.heater_Power);
            Assert.True(spExpected == controllerValues.heater_Params.sp);
            Assert.True(cvExpected == controllerValues.heater_Params.cv);
            Assert.True(pvExpected == controllerValues.heater_Params.pv);
            Assert.True(errorExpected == controllerValues.heater_Params.err);
        }
    }
}

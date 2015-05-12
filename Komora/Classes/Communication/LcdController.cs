using Komora.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Communication
{
    public class LcdController
    {
        private AT_Command atCommand;
        private ControllerValues controllerValues;

        public LcdController(ref AT_Command p_atCommand, ref ControllerValues p_controllerValues)
        {
            atCommand = p_atCommand;
            controllerValues = p_controllerValues;

            atCommand.AT_LCD_BKT_READ();
            atCommand.AT_LCD_CONTR_READ();
            atCommand.AT_DISPLAY_MODE_READ();
            atCommand.AT_TIME_DISPLAY_MODE_READ();
        }

        public void lcdNextScreen()
        {
            if (controllerValues.display_Mode < DISPLAY_MODE.TIME)
            {
                controllerValues.display_Mode += 1;
                atCommand.AT_DISPLAY_MODE(controllerValues.display_Mode);
                atCommand.AT_DISPLAY_MODE_READ();
            }
        }

        public void lcdPreviousScreen()
        {
            if (controllerValues.display_Mode > DISPLAY_MODE.INFO)
            {
                controllerValues.display_Mode -= 1;
                atCommand.AT_DISPLAY_MODE(controllerValues.display_Mode);
                atCommand.AT_DISPLAY_MODE_READ();
            }
        }

        public void changeTimeDisplayMode(string mode)
        {
            TIME_DISPLAY_MODE timeMode= TIME_DISPLAY_MODE.ERROR;
            switch (mode)
            {
                case "TIME":
                    timeMode = TIME_DISPLAY_MODE.TIME;
                break;
                case "DATE":
                    timeMode = TIME_DISPLAY_MODE.DATE;
                break;
                case "WEEKDAY":
                    timeMode = TIME_DISPLAY_MODE.WEEKDAY;
                break;
                case "ERROR":
                    timeMode = TIME_DISPLAY_MODE.ERROR;
                break;
            }

            atCommand.AT_TIME_DISPLAY_MODE(timeMode);
            atCommand.AT_TIME_DISPLAY_MODE_READ();
        }

        public void changeLedBargraphMode(string mode)
        {
            LED_BARGRAPH bargraphMode = LED_BARGRAPH.OFF;
            switch (mode)
            {
                case "OFF":
                    bargraphMode = LED_BARGRAPH.OFF;
                    break;
                case "HEATER_CV":
                    bargraphMode = LED_BARGRAPH.HEATER_CV;
                    break;
                case "DIODE_CV":
                    bargraphMode = LED_BARGRAPH.DIODE_CV;
                    break;
                case "HEATER_POWER":
                    bargraphMode = LED_BARGRAPH.HEATER_POWER;
                    break;
                case "DIODE_POWER":
                    bargraphMode = LED_BARGRAPH.HEATER_POWER;
                    break;
                case "ERROR":
                    bargraphMode = LED_BARGRAPH.ERROR;
                    break;
            }

            atCommand.AT_LED_BARGRAPH(bargraphMode);
            atCommand.AT_LED_BARGRAPH_READ();
        }

        public void setLcdCotrast(int contrastValue)
        {
            atCommand.AT_LCD_CONTR(contrastValue);
            atCommand.AT_TIME_DISPLAY_MODE_READ();
        }

        public void setLcdBackground()
        {
            atCommand.AT_LCD_BKT(!controllerValues.lcd_Bkt);
            atCommand.AT_LCD_BKT_READ();
        }




    }
}

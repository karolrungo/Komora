using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komora.DataTypes;

namespace Komora.Classes.Communication
{
    public class FrameParser
    {
        #region Main Parse Function
        internal void ParseInputString(string str, ref ControllerValues controllerValues)
        {
            char separator = '=';
            string[] splitted = str.Split(separator);

            switch (splitted[0])
            {
                //AT+LCD_CONTR?
                case "+LCD_CONTR":
                    controllerValues.lcd_Contr = SetValueFromInputString(splitted[1]);
                    break;
                //AT+LCD_BKT
                case "+LCD_BKT":
                    controllerValues.lcd_Bkt = Convert.ToBoolean(SetValueFromInputString(splitted[1]));
                    break;
                //AT+CONT_MODE
                case "+CONT_MODE":
                    controllerValues.cont_Mode = Set_Cont_Mode(splitted[1]);
                    break;
                //AT+PWM_MODE
                case "+CONTROL_MODE":
                    controllerValues.pwm_Mode = Set_PWM_Mode(splitted[1]);
                    break;
                //AT+DISPALY_MODE?
                case "+DISPALY_MODE":
                    controllerValues.display_Mode = Set_Display_Mode(splitted[1]);
                    break;
                //AT+TIME_DISPLAY_MODE?
                case "+TIME_DISPLAY_MODE":
                    controllerValues.time_Display_Mode = Set_Time_dispaly_mode(splitted[1]);
                    break;
                //AT+PID_HEATER_TUNES?
                case "+PID_HEATER_TUNES":
                    controllerValues.heater_Tunes = Set_Tunes(splitted[1]);
                    break;
                //AT+PID_DIODE?
                case "+PID_DIODE_TUNES":
                    controllerValues.diode_Tunes = Set_Tunes(splitted[1]);
                    break;
                //AT+HEATER_SP?
                case "+HEATER_SP":
                    controllerValues.heater_Params.sp = SetValueFromInputString(splitted[1]);
                    break;
                //AT+HEATER_CV?
                case "+HEATER_CV":
                    controllerValues.heater_Params.cv = SetValueFromInputString(splitted[1]);
                    break;
                //AT+HEATER_PV?
                case "+HEATER_PV":
                    controllerValues.heater_Params.pv = SetValueFromInputString(splitted[1]);
                    break;
                //AT+HEATER_POWER?
                case "+HEATER_POWER":
                    controllerValues.heater_Power = SetValueFromInputString(splitted[1]);
                    break;
                //AT+HEATER_PARAMS?
                case "+HEATER_PARAMS":
                    controllerValues.heater_Params = Set_Params(splitted[1]);
                    break;
                //AT+DIODE_SP?
                case "+DIODE_SP":
                    controllerValues.diode_Params.sp = SetValueFromInputString(splitted[1]);
                    break;
                //AT+DIODE_CV?
                case "+DIODE_CV":
                    controllerValues.diode_Params.cv = SetValueFromInputString(splitted[1]);
                    break;
                //AT+DIODE_PV?
                case "+DIODE_PV":
                    controllerValues.diode_Params.pv = SetValueFromInputString(splitted[1]);
                    break;
                //AT+DIODE_POWER?
                case "+DIODE_POWER":
                    controllerValues.heater_Power = SetValueFromInputString(splitted[1]);
                    break;
                //AT+DIODE_PARAMS?
                case "+DIODE_PARAMS":
                    controllerValues.diode_Params = Set_Params(splitted[1]);
                    break;
                //AT+LED_BARGRAPH?
                case "+LED_BARGRAPH":
                    controllerValues.led_Bargraph = Set_Led_Bargraph(splitted[1]);
                    break;
                //AT+CONTR_SEGMENT?
                case "+CONTR_SEGMENT":
                    controllerValues.contr_Segment = SetValueFromInputString(splitted[1]);
                    break;
                //AT+AUTO_SENDER_DATA?
                case "+AUTO_SENDER_DATA":
                    // TODO
                    break;
                //AT+PID_DIODE_SAMPLE?
                case "+PID_DIODE_SAMPLE":
                    controllerValues.diode_sample = SetValueFromInputString(splitted[1]);
                    break;
                //AT+PID_HEATER_SAMPLE?
                case "+PID_HEATER_SAMPLE":
                    controllerValues.heater_sample = SetValueFromInputString(splitted[1]);
                    break;
                //AT+HARDWARE_CONF?
                case "+HARDWARE_CONF":
                    controllerValues.hardware_conf = Set_Hardware_Configuration(splitted[1]);
                    break;
                //+PT100_AUTO_DATA
                case "+PT100_AUTO_DATA":
                    PT100_AutoDataParser(splitted[1], out controllerValues.ch1_result, out controllerValues.pt100_ch_result);
                    break;
                //+HEATER_AUTO_DATA
                case "+HEATER_AUTO_DATA":
                    AutoDataParser(splitted[1], out controllerValues.heater_Power, out controllerValues.heater_Params);
                    break;
                //+DIODE_AUTO_DATA
                case "+DIODE_AUTO_DATA":
                    AutoDataParser(splitted[1], out controllerValues.diode_Power, out controllerValues.diode_Params);
                    break;
            }
        }
        #endregion

        #region Small Parsers
        private static void AutoDataParser(string p, out double power, out RegulationParameters param)
        {
            char separator = ':';
            string[] splitted = p.Split(separator);
            param = new RegulationParameters();
            power = double.MinValue;

            //w zaleznosci od trybu pracy sterownika, urzadzenie zwraca string o roznej dlugosci
            switch (splitted.Length)
            {
                //tryb OPEN
                case 2:
                    AutDataParserOPEN(splitted, out power);
                    break;
                //tryb FEEDBACK
                case 6:
                    AutoDataParserFEEDBACK(splitted, out power, out param);
                    break;
                default:
                    return;
            }
        }
        private static void AutoDataParserFEEDBACK(string[] splitted, out double power, out RegulationParameters param)
        {
            param = new RegulationParameters();
            try
            {
                power = double.Parse(splitted[0]);
                param.sp = double.Parse(splitted[2]);
                param.cv = double.Parse(splitted[3]);
                param.pv = double.Parse(splitted[4]);
                param.err = double.Parse(splitted[5]);
            }
            catch (Exception)
            {
                power = double.MinValue;
                param = new RegulationParameters();
            }
        }
        private static void AutDataParserOPEN(string[] splitted, out double power)
        {
            try
            {
                power = double.Parse(splitted[0]);
            }
            catch (Exception)
            {
                power = double.MinValue;
            }
        }
        private static void PT100_AutoDataParser(string p, out int ch1, out int pt100_ch)
        {
            char separator = ':';
            string[] splitted = p.Split(separator);

            try
            {
                ch1 = Int32.Parse(splitted[0]);
                pt100_ch = Int32.Parse(splitted[1]);
            }
            catch (Exception)
            {
                ch1 = int.MinValue;
                pt100_ch = int.MinValue;
                return;
            }
        }
        private static Hardware_Conf Set_Hardware_Configuration(string p)
        {
            char separator = ':';
            string[] splitted = p.Split(separator);
            Hardware_Conf hwd_Conf = new Hardware_Conf();

            try
            {
                hwd_Conf.atmega_aref = Int32.Parse(splitted[0]);
                hwd_Conf.pt100_ref_res = Int32.Parse(splitted[1]);
                return hwd_Conf;
            }
            catch (Exception)
            {
                return new Hardware_Conf();
            }

        }
        private static LED_BARGRAPH Set_Led_Bargraph(string p)
        {
            switch (p)
            {
                case "OFF":
                    return LED_BARGRAPH.OFF;
                case "HEATER_CV":
                    return LED_BARGRAPH.HEATER_CV;
                case "DIODE_CV":
                    return LED_BARGRAPH.DIODE_CV;
                case "HEATER_POWER":
                    return LED_BARGRAPH.HEATER_POWER;
                case "DIODE_POWER":
                    return LED_BARGRAPH.DIODE_POWER;
                default:
                    return LED_BARGRAPH.ERROR;
            }
        }
        private static RegulationParameters Set_Params(string p)
        {
            char separator = ':';
            string[] splitted = p.Split(separator);
            RegulationParameters param = new RegulationParameters();

            try
            {
                param.sp = double.Parse(splitted[0]);
                param.cv = double.Parse(splitted[1]);
                param.err = double.Parse(splitted[2]);
                param.pv = double.Parse(splitted[3]);
                param.dateTime = DateTime.Now;
                return param;
            }
            catch (Exception)
            {
                return new RegulationParameters();
            }

        }
        private static Tunes Set_Tunes(string p)
        {
            char separator = ':';
            string[] splitted = p.Split(separator);
            Tunes tunes = new Tunes();

            try
            {
                tunes.kp = Int32.Parse(splitted[0]);
                tunes.ki = Int32.Parse(splitted[1]);
                tunes.kd = Int32.Parse(splitted[2]);
                tunes.scal = Int32.Parse(splitted[3]);
                return tunes;
            }
            catch (Exception)
            {
                return new Tunes();
            }
        }
        private static TIME_DISPLAY_MODE Set_Time_dispaly_mode(string p)
        {
            switch (p)
            {
                case "TIME":
                    return TIME_DISPLAY_MODE.TIME;
                case "DATE":
                    return TIME_DISPLAY_MODE.DATE;
                case "WEEKDAY":
                    return TIME_DISPLAY_MODE.WEEKDAY;
                default:
                    return TIME_DISPLAY_MODE.ERROR;
            }
        }
        private static DISPLAY_MODE Set_Display_Mode(string p)
        {
            switch (p)
            {
                case "INFO":
                    return DISPLAY_MODE.INFO;
                case "PT100_VOLT":
                    return DISPLAY_MODE.PT100_VOLT;
                case "PT100_PARAMS":
                    return DISPLAY_MODE.PT100_PARAMS;
                case "HEATER_PARAMS":
                    return DISPLAY_MODE.HEATER_PARAMS;
                case "DIODE_PARAMS":
                    return DISPLAY_MODE.DIODE_PARAMS;
                case "TIME":
                    return DISPLAY_MODE.TIME;
                default:
                    return DISPLAY_MODE.ERROR;
            }
        }
        private static CONTROL_MODE Set_PWM_Mode(string p)
        {
            switch (p)
            {
                case "OFF":
                    return CONTROL_MODE.OFF;
                case "BOTH":
                    return CONTROL_MODE.BOTH;
                case "HEATER":
                    return CONTROL_MODE.HEATER;
                case "DIODE":
                    return CONTROL_MODE.DIODE;
                default:
                    return CONTROL_MODE.ERROR;
            }
        }
        private static CONT_MODE Set_Cont_Mode(string p)
        {
            switch (p)
            {
                case "IDLE":
                    return CONT_MODE.IDLE;
                case "OPEN":
                    return CONT_MODE.OPEN;
                case "FEEDBACK":
                    return CONT_MODE.FEEDBACK;
                default:
                    return CONT_MODE.ERROR;
            }
        }
        private static int SetValueFromInputString(string p)
        {
            Console.WriteLine("dupa");
            try
            {
                int value = Int32.Parse(p);
                return value;
            }
            catch (Exception)
            {
                return Int32.MinValue;
            }
        }
        #endregion
    }
}

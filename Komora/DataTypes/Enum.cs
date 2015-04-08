using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public enum CONT_MODE { IDLE, OPEN, FEEDBACK, ERROR }; //tryby dzialania sterownika
    public enum CONTROL_MODE { BOTH, HEATER, DIODE, OFF, ERROR }; //tryby dzialania PWM
    public enum DISPLAY_MODE { INFO, PT100_VOLT, PT100_PARAMS, HEATER_PARAMS, DIODE_PARAMS, TIME, ERROR }; //informacje wyswietlane na lcd
    public enum TIME_DISPLAY_MODE { TIME, DATE, WEEKDAY, ERROR } //tryb wyswietlania czasu na lcd
    public enum PID_INTEGER_RESET { BOTH, DIODE, HEATER, ERROR } //resetowanie integratora (tylko w feedback)
    public enum LED_BARGRAPH { OFF, HEATER_CV, DIODE_CV, HEATER_POWER, DIODE_POWER, ERROR } //wskaznik diodowy
}

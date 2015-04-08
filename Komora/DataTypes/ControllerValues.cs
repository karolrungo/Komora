using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public class ControllerValues
    {
        public int lcd_Contr; //(0-129)
        public bool lcd_Bkt; // (0 or 1)
        public CONT_MODE cont_Mode;
        public CONTROL_MODE pwm_Mode;
        public DISPLAY_MODE display_Mode;
        public TIME_DISPLAY_MODE time_Display_Mode;
        public Tunes heater_Tunes;
        public Tunes diode_Tunes;
        public RegulationParameters heater_Params;
        public RegulationParameters diode_Params;
        public double diode_Power;
        public double heater_Power;
        public LED_BARGRAPH led_Bargraph;
        public int contr_Segment; //(0-255)
        public int heater_sample;
        public int diode_sample;
        public Hardware_Conf hardware_conf;
        public bool auto_Sender_Data;

        public int ch1_result;
        public int pt100_ch_result;

        public string str;

        public ControllerValues()
        {
            lcd_Bkt = false;
            cont_Mode = CONT_MODE.IDLE;
            pwm_Mode = CONTROL_MODE.OFF;
            display_Mode = DISPLAY_MODE.INFO;
            time_Display_Mode = TIME_DISPLAY_MODE.TIME;
            led_Bargraph = LED_BARGRAPH.OFF;
            heater_Tunes = new Tunes();
            diode_Tunes = new Tunes();
            heater_Params = new RegulationParameters();
            diode_Params = new RegulationParameters();
        }

        public string Heater_Power
        {
            get
            {
                if (heater_Power == double.MinValue) return "NO DATA";
                else return (heater_Power / 100).ToString("0.00");
            }
        }
    }
}

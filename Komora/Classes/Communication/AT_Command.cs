using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komora.DataTypes;
using System.IO.Ports;
using System.Windows.Forms;

namespace Komora.Classes.Communication
{
    public class AT_Command
    {
        #region Private Variables
        private string sender;
        private List<string> recivedStrings;
        private List<string> sendedStrings;
        private SerialPort port;
        #endregion

        #region Constructor
        public AT_Command(string serialPortName)
        {
            recivedStrings = new List<string>();
            sendedStrings = new List<string>();

            port = new SerialPort();
            SerialPortSeetings(serialPortName);
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            port.Open();
        }
        #endregion

        #region Public Properties
        public List<string> RecivedStrings { get { return recivedStrings; } }
        public List<string> SendedStrings { get { return sendedStrings; } }
        public SerialPort SerialPort { get { return port; } }
        #endregion


        private void SendAT_Command()
        {
            lock (RecivedStrings)
            {
                try
                {
                    port.Write(FormatCommandString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string FormatCommandString()
        {
            sender += "\r";
            return sender;
        }

        #region Commands Write
        public void AT()
        {
            sender = "AT";
            SendAT_Command(); ;
        }
        public void ATI()
        {
            sender = "ATI";
            SendAT_Command();
        }
        public void AT_Reset()
        {
            sender = "AT+RST";
            SendAT_Command();
        }
        public void AT_LCD_CONTR(int value)
        {
            sender = "AT+LCD_CONTR=" + value.ToString();
            SendAT_Command();
        }
        public void AT_LCD_BKT(bool value)
        {
            if (value) sender = "AT+LCD_BKT=1";
            else sender = "AT+LCD_BKT=0";

            SendAT_Command();
        }
        public void AT_CONT_MODE(CONT_MODE mode)
        {
            switch (mode)
            {
                case CONT_MODE.IDLE:
                    sender = "AT+CONT_MODE=IDLE";
                    break;
                case CONT_MODE.OPEN:
                    sender = "AT+CONT_MODE=OPEN";
                    break;
                case CONT_MODE.FEEDBACK:
                    sender = "AT+CONT_MODE=FEEDBACK";
                    break;
                default:
                    sender = "AT+CONT_MODE=IDLE";
                    break;
            }
            SendAT_Command();
        }
        public void AT_CONTROL_MODE(CONTROL_MODE mode)
        {
            switch (mode)
            {
                case CONTROL_MODE.OFF:
                    sender = "AT+CONTROL_MODE=OFF";
                    break;
                case CONTROL_MODE.BOTH:
                    sender = "AT+CONTROL_MODE=BOTH";
                    break;
                case CONTROL_MODE.DIODE:
                    sender = "AT+CONTROL_MODE=DIODE";
                    break;
                case CONTROL_MODE.HEATER:
                    sender = "AT+CONTROL_MODE=HEATER";
                    break;
                default:
                    sender = "AT+CONTROL_MODE=OFF";
                    break;
            }
            SendAT_Command();
        }
        public void AT_DISPLAY_MODE(DISPLAY_MODE mode)
        {
            switch (mode)
            {
                case DISPLAY_MODE.DIODE_PARAMS:
                    sender = "AT+DISPLAY_MODE=DIODE_PARAMS";
                    break;
                case DISPLAY_MODE.INFO:
                    sender = "AT+DISPLAY_MODE=INFO";
                    break;
                case DISPLAY_MODE.PT100_VOLT:
                    sender = "AT+DISPLAY_MODE=PT100_VOLT";
                    break;
                case DISPLAY_MODE.PT100_PARAMS:
                    sender = "AT+DISPLAY_MODE=PT100_PARAMS";
                    break;
                case DISPLAY_MODE.HEATER_PARAMS:
                    sender = "AT+DISPLAY_MODE=HEATER_PARAMS";
                    break;
                case DISPLAY_MODE.TIME:
                    sender = "AT+DISPLAY_MODE=TIME";
                    break;
                default:
                    sender = "AT+DISPLAY_MODE=INFO";
                    break;
            }
            SendAT_Command();
        }
        public void AT_TIME_DISPLAY_MODE(TIME_DISPLAY_MODE mode)
        {
            switch (mode)
            {
                case TIME_DISPLAY_MODE.TIME:
                    sender = "AT+TIME_DISPLAY_MODE=TIME";
                    break;
                case TIME_DISPLAY_MODE.DATE:
                    sender = "AT+TIME_DISPLAY_MODE=DATE";
                    break;
                case TIME_DISPLAY_MODE.WEEKDAY:
                    sender = "AT+TIME_DISPLAY_MODE=WEEKDAY";
                    break;
                default:
                    sender = "AT+TIME_DISPLAY_MODE=TIME";
                    break;
            }
            SendAT_Command();
        }
        public void AT_PID_HEATER_TUNES(long kp, long ki, long kd, long scal)
        {
            string kp_str = (kp).ToString();
            string ki_str = (ki).ToString();
            string kd_str = (kd).ToString();
            sender = "AT+PID_HEATER_TUNES=" + kp_str + ":" + ki_str + ":" + kd_str + ":" + scal.ToString();
            SendAT_Command();
        }
        public void AT_PID_DIODE_TUNES(long kp, long ki, long kd, long scal)
        {
            string kp_str = (kp).ToString();
            string ki_str = (ki).ToString();
            string kd_str = (kd).ToString();
            sender = "AT+PID_DIODE_TUNES=" + kp_str + ":" + ki_str + ":" + kd_str + ":" + scal.ToString();
            SendAT_Command();
        }
        public void AT_PID_INTEGR_RESET(PID_INTEGER_RESET mode)
        {
            switch (mode)
            {
                case PID_INTEGER_RESET.BOTH:
                    sender = "AT+PID_INTEGR_RESET=BOTH";
                    break;
                case PID_INTEGER_RESET.DIODE:
                    sender = "AT+PID_INTEGR_RESET=DIODE";
                    break;
                case PID_INTEGER_RESET.HEATER:
                    sender = "AT+PID_INTEGR_RESET=HEATER";
                    break;
                default:
                    sender = "AT+PID_INTEGR_RESET=BOTH";
                    break;
            }
            SendAT_Command();
        }
        public void AT_HEATER_SP(long sp) //!!!!!!!
        {
            sender = "AT+HEATER_SP=" + sp.ToString();
            SendAT_Command();
        }
        public void AT_HEATER_CV(long cv)
        {
            sender = "AT+HEATER_CV=" + cv.ToString();
            SendAT_Command();
        }
        public void AT_DIODE_SP(long sp)
        {
            sender = "AT+DIODE_SP=" + sp.ToString();
            SendAT_Command();
        }
        public void AT_LED_BARGRAPH(LED_BARGRAPH mode)
        {
            switch (mode)
            {
                case LED_BARGRAPH.OFF:
                    sender = "AT+LED_BARGRAPH=OFF";
                    break;
                case LED_BARGRAPH.DIODE_CV:
                    sender = "AT+LED_BARGRAPH=DIODE_CV";
                    break;
                case LED_BARGRAPH.DIODE_POWER:
                    sender = "AT+LED_BARGRAPH=DIODE_POWER";
                    break;
                case LED_BARGRAPH.HEATER_CV:
                    sender = "AT+LED_BARGRAPH=HEATER_CV";
                    break;
                case LED_BARGRAPH.HEATER_POWER:
                    sender = "AT+LED_BARGRAPH=HEATER_POWER";
                    break;
                default:
                    sender = "AT+LED_BARGRAPH=OFF";
                    break;
            }
            SendAT_Command();

        }
        public void AT_CONTR_SEGMENT() //TODO
        { }
        public void AT_AUTO_SENDER_DATA(bool value)
        {
            if (value)
                sender = "AT+AUTO_SENDER_DATA=1";
            else
                sender = "AT+AUTO_SENDER_DATA=0";

            SendAT_Command();
        }
        public void AT_PID_HEATER_SAMPLE(long value)
        {
            sender = "AT+PID_HEATER_SAMPLE=" + value.ToString();
            SendAT_Command();
        }
        public void AT_PID_DIODE_SAMPLE(long value)
        {
            sender = "AT+PID_DIODE_SAMPLE=" + value.ToString();
            SendAT_Command();
        }
        public void AT_HARDWARE_CONF(int atmega_aref, int pt100_ref_res)
        {
            sender = "AT+HARDWARE_CONF=" + atmega_aref.ToString() + ":" + pt100_ref_res.ToString();
            SendAT_Command();
        }
        public void AT_TEMPERATURE_VALUE(int value)
        {
            sender = "AT+TEMPERATURE_VALUE=" + value.ToString();
            SendAT_Command();
        }
        #endregion

        #region Commands Read
        public void AT_HEATER_ERR_READ()
        {
            sender = "AT+HEATER_ERR?";
            SendAT_Command();
        }
        public void AT_HEATER_PV_READ()
        {
            sender = "AT+HEATER_PV?";
            SendAT_Command();
        }
        public void AT_HEATER_SP_READ()
        {
            sender = "AT+HEATER_SP?";
            SendAT_Command();
        }
        public void AT_HEATER_CV_READ()
        {
            sender = "AT+HEATER_CV?";
            SendAT_Command();
        }
        public void AT_HEATER_POWER_READ()
        {
            sender = "AT+HEATER_POWER?";
            SendAT_Command();
        }
        public void AT_HEATER_PARAMS_READ()
        {
            sender = "AT+HEATER_PARAMS?";
            SendAT_Command();
        }
        public void AT_DIODE_SP_READ()
        {
            sender = "AT+DIODE_SP?";
            SendAT_Command();
        }
        public void AT_DIODE_CV_READ()
        {
            sender = "AT+DIODE_CV?";
            SendAT_Command();
        }
        public void AT_DIODE_ERR_READ()
        {
            sender = "AT+DIODE_PV?";
            SendAT_Command();
        }
        public void AT_DIODE_POWER_READ()
        {
            sender = "AT+DIODE_POWER?";
            SendAT_Command();
        }
        public void AT_DIODE_PARAMS_READ()
        {
            sender = "AT+DIODE_PARAMS?";
            SendAT_Command();
        }
        public void AT_CONTR_SEGMENT_READ()
        {
            sender = "AT+AT_CONTR_SEGMENT?";
            SendAT_Command();
        }
        public void AT_LCD_CONTR_READ()
        {
            sender = "AT+LCD_CONTR?";
            SendAT_Command();
        }
        public void AT_LCD_BKT_READ() //check
        {
            sender = "AT+LCD_BKT?";
            SendAT_Command();
        }
        public void AT_CONT_MODE_READ()
        {
            sender = "AT+CONT_MODE?";
            SendAT_Command();
        }
        public void AT_CONTROL_MODE_READ()
        {
            sender = "AT+CONTROL_MODE?";
            SendAT_Command();
        }
        public void AT_DISPLAY_MODE_READ()
        {
            sender = "AT+DISPLAY_MODE?";
            SendAT_Command();
        }
        public void AT_TIME_DISPLAY_MODE_READ()
        {
            sender = "AT+TIME_DISPLAY_MODE?";
            SendAT_Command();
        }
        public void AT_PID_HEATER_TUNES_READ()
        {
            sender = "AT+PID_HEATER_TUNES?";
            SendAT_Command();
        }
        public void AT_PID_DIODE_TUNES_READ()
        {
            sender = "AT+PID_DIODE_TUNES?";
            SendAT_Command();
        }
        public void AT_AUTO_SENDER_DATA_READ()
        {
            sender = "AT+AUTO_SENDER_DATA?";
            SendAT_Command();
        }
        public void AT_PID_HEATER_SAMPLE_READ()
        {
            sender = "AT+PID_HEATER_SAMPLE?";
            SendAT_Command();
        }
        public void AT_PID_DIODE_SAMPLE_READ()
        {
            sender = "AT+PID_DIODE_SAMPLE?";
            SendAT_Command();
        }
        #endregion

        #region Serial Port
        /// <summary>
        /// funkcja ustawia parametry transmisji 
        /// dla komory przez port szeregowy
        /// </summary>
        /// <returns></returns>
        private void SerialPortSeetings(string name)
        {
            int baudrate = 115200;
            int dataBits = 8;
            int stopBits = 1;
            Parity parity = Parity.None;
            port.PortName = name;
            port.BaudRate = baudrate;
            port.DataBits = dataBits;
            port.ReceivedBytesThreshold = stopBits;
            port.Parity = parity;
            port.ParityReplace = 63;
            port.ReadBufferSize = 4096;
            port.WriteBufferSize = 2048;
            port.ReadTimeout = -1;
        }
        /// <summary>
        /// funkcja realizujaca odbior danych z portu szeregowego
        /// konieczne jest zastosowanie monitorow,
        /// w celu synchronizacji watkow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                lock (RecivedStrings)
                {
                    if (port.IsOpen)
                    {
                        while (port.BytesToRead > 0)
                        {
                            string frame = port.ReadLine();
                            RecivedStrings.Add(frame);
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }
        internal void CancelSerialPortDataRecivedHandler()
        {
            this.port.DataReceived -= DataReceivedHandler;
        }
        internal void CloseSerialPort()
        {
            port.Close();
        }
        #endregion
    }
}

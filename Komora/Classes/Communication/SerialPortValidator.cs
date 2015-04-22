using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace Komora.Classes.Communication
{
    public class SerialPortValidator
    {
        public SerialPortValidator()
        { }

        public bool portExists(string portName)
        {
            if (portHasValidName(portName))
            {
                string[] avaliblePorts = SerialPort.GetPortNames();
                return avaliblePorts.Contains(portName);
            }
            else
            {
                return false;
            }
        }

        public bool portHasValidName(string portName)
        {
            string sPattern = "^COM\\d+$";
            return Regex.IsMatch(portName, sPattern);
        }
    }
}

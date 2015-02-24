using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Chamber
{
    public class ChamberData
    {
        private string _name;
        private string _serialPort;
        private int _number;

        public ChamberData() { }
        public ChamberData(string name, string serialPort, int number)
        {
            setChamberData(name, serialPort, number);
        }

        public string Name { get{ return _name;} set{ _name = value.ToString();} }
        public string SerialPort { get { return _serialPort; } set { _serialPort = value.ToString(); } }
        public int Number { get { return _number; } set { _number = value; } }

        public void setChamberData(string name, string serialPort, int number)
        {
            this._name = name;
            this._serialPort = serialPort;
            this._number = number;
        }
    }
}

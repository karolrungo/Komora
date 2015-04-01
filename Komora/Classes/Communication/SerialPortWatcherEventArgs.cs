using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Komora.Classes.Communication
{
    public class SerialPortWatcherEventArgs : EventArgs
    {
        public List<string> comPorts;

        public SerialPortWatcherEventArgs(List<string> comPorts)
        {
            this.comPorts = comPorts;
        }
    }
}

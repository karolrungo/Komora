using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Management;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.Classes.Communication
{
    public class SerialPortWatcher
    {
        System.Timers.Timer timer;
        List<string> comPorts;
        public delegate void EventHandler(object sender, SerialPortWatcherEventArgs e);
        public event EventHandler comPortsUpdate;

        public SerialPortWatcher(double timerIntervalMiliseconds)
        {
            timer = new System.Timers.Timer(timerIntervalMiliseconds);
            timer.Enabled = true;
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        ~SerialPortWatcher()
        {
            timer.Stop();
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            comPorts = SerialPort.GetPortNames().ToList();
            ForwardTimerTickEvent();
        }

        private void ForwardTimerTickEvent()
        {
            if (comPortsUpdate != null)
            {
                comPortsUpdate(this, new SerialPortWatcherEventArgs(comPorts));
            }
        }
    }
}

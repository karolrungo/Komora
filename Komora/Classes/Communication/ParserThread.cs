using Komora.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Komora.Classes.Communication
{
    public class ParserThread
    {
        private Thread parserThread;
        private List<string> recivedStrings;
        private ControllerValues controllerValues;
        private List<string> copyRecivedStrings;
        FrameParser frameParser = new FrameParser();

        public delegate void SendRecivedCommands(object sender, RecivedCommandsEventArgs e);
        public event SendRecivedCommands sendRecivedCommandsEvent;

        public ParserThread(List<string> recived, ref ControllerValues values)
        {
            recivedStrings = recived;
            controllerValues = values;

            parserThread = new Thread(new ThreadStart(Parse));
            parserThread.Start();
        }

        /// <summary>
        /// glowna funkcja do obslugi watku parsujacego stringi
        /// z portu szeregowegop
        /// </summary>
        private void Parse()
        {
            while (true)
            {
                    lock (recivedStrings)
                    {
                        copyRecivedStrings = new List<string>(recivedStrings);
                        recivedStrings.Clear();
                    }

                    raiseSendRecivedCommand();

                    try
                    {
                        foreach (string str in copyRecivedStrings)
                        {
                            frameParser.ParseInputString(str, ref controllerValues);
                        }//foreach  
                    }//try
                    finally { }
                    
                Thread.Sleep(100);
            }
        }

        internal void Stop()
        {
            if (parserThread.IsAlive)
            {
                parserThread.Abort();
            }
        }

        private void raiseSendRecivedCommand()
        {
            if (sendRecivedCommandsEvent != null)
            {
                sendRecivedCommandsEvent(this, new RecivedCommandsEventArgs(copyRecivedStrings));
            }
        }
    }
}

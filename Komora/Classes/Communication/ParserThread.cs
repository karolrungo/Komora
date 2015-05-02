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
        private int dataCounter;
        private List<string> copy;
        FrameParser frameParser = new FrameParser();

        public ParserThread(List<string> recived, ref ControllerValues values)
        {
            dataCounter = 0; // co to jest??

            recivedStrings = recived;
            controllerValues = values;


            parserThread = new Thread(new ThreadStart(Parse));
            parserThread.Start();
        }

        #region Threads Main Functions
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
                        copy = new List<string>(recivedStrings);
                        recivedStrings.Clear();
                    }
                        try
                        {
                            foreach (string str in copy)
                            {
                                frameParser.ParseInputString(str, ref controllerValues);
                            }//foreach  
                        }//try
                        finally { }
                    
                Thread.Sleep(100);
            }
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// wlasciwosc zwraca watek parsera 
        /// aby mozna go bylo zakonczyc w innym oknie
        /// </summary>
       // public Thread ParserThread { get { return parserThread; } }
        #endregion


        internal void Stop()
        {
            if (parserThread.IsAlive)
            {
                parserThread.Abort();
            }
        }
    }
}

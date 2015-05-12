using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komora.Classes.Communication
{
    public class RecivedCommandsEventArgs
    {
        public List<string> recivedCommands;
        private List<string> copyRecivedStrings;

        public RecivedCommandsEventArgs(List<string> p_recivedCommands)
        {
            recivedCommands = new List<string>(p_recivedCommands);
        }
    }
}

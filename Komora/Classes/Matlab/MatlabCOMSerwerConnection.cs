using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLApp;

namespace Komora.Classes.Matlab
{
    public class MatlabCOMSerwer : IMatlabConnector
    {
        private Type activationContext;
        private MLApp.MLApp matlab;

        ~MatlabCOMSerwer()
        {
            disconnect();
        }

        public bool connect()
        {
            activationContext = Type.GetTypeFromProgID("matlab.application.single");
            matlab = (MLApp.MLApp)Activator.CreateInstance(activationContext);
            return true;
        }

        public bool disconnect()
        {
            matlab.Quit();
            return true;
        }

        public void exectuteStatement(string statement)
        {
            throw new NotImplementedException();
        }
    }
}

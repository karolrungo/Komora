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

        public void exectuteStatement(string scriptPath, List<double> errorValues, List<double> timeDeltas)
        {
            var matlab = (MLApp.MLApp)Activator.CreateInstance(activationContext);
            matlab.PutWorkspaceData("error", "base", errorValues.ToArray());
            matlab.PutWorkspaceData("timeDeltas", "base", timeDeltas.ToArray());
            matlab.Execute(@"cd " + scriptPath);
        }
    }
}

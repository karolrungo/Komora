using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLApp;
using System.Windows.Forms;

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
            return true;
        }

        public void exectuteStatement(string scriptPath, List<double> errorValues, List<double> timeDeltas)
        {
            matlab.Execute(@"cd " + scriptPath);
            object result;
            matlab.Feval("test",1, out result, errorValues.ToArray(), timeDeltas.ToArray());

            object[] res = result as object[];
            MessageBox.Show("ISE = " + res[0].ToString());
        }
    }
}

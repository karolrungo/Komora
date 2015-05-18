using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Matlab
{
    public interface IMatlabConnector
    {
        bool connect();
        bool disconnect();

        void exectuteStatement(string scriptPath, List<double> errorValues, List<double> timeDeltas);
    }
}

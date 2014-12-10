using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Matlab
{
    public class MatlabConnectionProxy: IMatlabConnection
    {
        IMatlabConnector matlabConnector;

        public MatlabConnectionProxy(IMatlabConnector matlabConnector)
        {
            this.matlabConnector = matlabConnector;
            matlabConnector.connect();
        }

        void IMatlabConnection.exectuteStatement(string statement)
        {
 
        }
    }
}

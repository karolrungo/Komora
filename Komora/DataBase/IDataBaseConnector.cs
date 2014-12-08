using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataBase
{
    public interface IDataBaseConnector
    {
        bool Connect();
        bool Disconnect();
    }
}

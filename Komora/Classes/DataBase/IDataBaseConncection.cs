using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.DataBase
{
    public interface IDataBaseConncection
    {
        User getUser(int id);
        User getUserByCredentials(string login, string password);

        HardwareConfiguration getHardwareConfiguration(int id);
    }
}

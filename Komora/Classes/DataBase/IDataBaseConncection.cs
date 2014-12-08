using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.DataBase
{
    public interface IDataBaseConncection
    {
        object getUser(int id);

        object getUserByCredentials(string login, string password);
    }
}

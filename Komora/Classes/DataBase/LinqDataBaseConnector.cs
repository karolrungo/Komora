using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.DataBase

{
    public class LinqDataBaseConnector : IDataBaseConnector
    {
        private LinqDatabaseDataContext dataContext;

        public bool connect()
        {
            dataContext = new LinqDatabaseDataContext();
            if (dataContext.DatabaseExists())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool disconnect()
        {
            try
            {
                dataContext.Dispose();
                return true;
            }
            catch (NullReferenceException)
            { 
                return false;
            }
        }

        public User getUser(string login, string password)
        {
            return this.dataContext.Users.First(x => x.username == login && x.password == password);
        }
        public User getUser(int id)
        {
            return this.dataContext.Users.First(x => x.ID == id);
        }

        public HardwareConfiguration getHardwareConfiguration(int id)
        {
            return this.dataContext.HardwareConfigurations.First(x => x.ID == id);
        }
    }
}

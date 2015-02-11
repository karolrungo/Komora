using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.DataBase
{
    public class DataBaseConnectionProxy : IDataBaseConncection
    {
        private IDataBaseConnector dbConnector;

        public DataBaseConnectionProxy(IDataBaseConnector dataBaseConnector)
        {
            this.dbConnector = dataBaseConnector;

            if (false == dbConnector.connect())
            {
                throw new DatabaseConnectionException("Can't establish connection to database.");
            }
        }
        ~DataBaseConnectionProxy()
        {
            if (false == dbConnector.disconnect())
            {
                throw new DatabaseConnectionException("Can't disconnect from database.");
            }
        }

        public bool connect()
        {
            return dbConnector.connect();
        }
        public bool disconnect()
        {
            return dbConnector.disconnect();
        }

        public User getUser(int id)
        {
            return dbConnector.getUser(id);
        }
        public User getUserByCredentials(string login, string password)
        {
            //gdzie lapac wyjatek
            return dbConnector.getUser(login, password);
        }

        public HardwareConfiguration getHardwareConfiguration(int id)
        {
            return dbConnector.getHardwareConfiguration(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.DataBase
{
    public class DataBaseConnectionProxy : IDataBaseConncection
    {
        #region Private Variables
        private IDataBaseConnector dataBaseConnector;
        #endregion

        #region Constructors
        public DataBaseConnectionProxy(IDataBaseConnector dataBaseConnector)
        {
            this.dataBaseConnector = dataBaseConnector;
        }
        #endregion

        #region IBdataBaseConnection Implementation
        object IDataBaseConncection.getUser(int id)
        {
            //var query = from c in ...
            throw new NotImplementedException();
        }

        object IDataBaseConncection.getUserByCredentials(string login, string password)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

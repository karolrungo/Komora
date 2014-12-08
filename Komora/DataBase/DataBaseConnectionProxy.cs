using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataBase
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
        Object IDataBaseConncection.getUser(int id)
        {
            //var query = from c in ...
            throw new NotImplementedException();
        }
        #endregion
    }
}

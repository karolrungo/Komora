using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.DataBase

{
    public class LinqDataBaseConnector : IDataBaseConnector
    {
        #region Private Variables
        LinqDatabaseDataContext dataContext;
        #endregion

        #region Public Methods
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
                if (dataContext.DatabaseExists())
                {
                    dataContext.Dispose();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            { 
                return false;
            }

        }
        #endregion
    }
}

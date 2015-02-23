using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komora.Classes;
using Komora.Classes.DataBase;

namespace Komora.Classes.Loger
{
    public class LogerDataBase : Loger
    {
        #region Private Variables
        DataBase.IDataBaseConnector dataBaseConnector;
        #endregion

        #region Constructor
        public LogerDataBase(DataBase.IDataBaseConnector dataBaseConnector)
        {
            this.dataBaseConnector = dataBaseConnector;
        }
        #endregion

        #region Derived Methods
        public override void validateUser(string login, string password)
        {
            try
            {
                dataBaseConnector.getUser(login, password);
            }
            catch
            {
                RaiseLoginFailedEvent(EventArgs.Empty);
                return;
            }

            RaiseLoginSuccesEvent(EventArgs.Empty);
        }
        #endregion      
    }
}

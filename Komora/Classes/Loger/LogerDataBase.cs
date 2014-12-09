using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komora.Classes;

namespace Komora.Classes.Loger
{
    public class LogerDataBase : Loger
    {
        #region Private Variables
        DataBase.IDataBaseConncection dataBaseConnection;
        #endregion

        #region Constructor
        public LogerDataBase(DataBase.IDataBaseConncection dataBaseConnection)
        {
            this.dataBaseConnection = dataBaseConnection;
        }
        #endregion

        #region Derived Methods
        public override void validateUser(string login, string password)
        {
            if (LogInSuccess(login, password))
            {
                RaiseLoginSuccesEvent(EventArgs.Empty);
            }
        }
        #endregion

        #region Private Methods
        private bool LogInSuccess(string login, string password)
        {
            if (null != dataBaseConnection.getUserByCredentials(login, password))
                return true;
            else
                return false;
        }
        #endregion
         
    }
}

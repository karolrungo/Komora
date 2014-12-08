using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Loger
{
    public abstract class Loger
    {
        #region Private Variables
        protected bool validationOK;
        #endregion

        #region Constructor
        public Loger()
        {
            validationOK = false;
        }
        #endregion

        #region Public Methods
        public abstract void validateUser(string login, string password) ;
        public bool canLogIn()
        {
            return validationOK;
        }
        public void resetLogIn()
        {
            validationOK = false;
        }
        #endregion
    }
}

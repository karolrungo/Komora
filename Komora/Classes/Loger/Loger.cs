using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Loger
{
    public abstract class Loger
    {
        #region Events & Delegates
        public delegate void LoginStatus(object sender, EventArgs e);
        public event LoginStatus loginSucces;
        public event LoginStatus loginFailed;
        #endregion

        #region Public Methods
        public abstract void validateUser(string login, string password);
        #endregion

        #region Protected Moetods
        protected void RaiseLoginSuccesEvent(EventArgs eventArgs)
        {
            if (loginSucces != null)
            {
                loginSucces(this, eventArgs);
            }
        }

        protected void RaiseLoginFailedEvent(EventArgs eventArgs)
        {
            if (loginFailed != null)
            {
                loginFailed(this, eventArgs);
            }
        }
        #endregion
    }
}

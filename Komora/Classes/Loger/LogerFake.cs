using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Loger
{
    class LogerFake : Loger
    {
        #region Override methods
        public override void validateUser(string login, string password)
        {
            RaiseLoginSuccesEvent(EventArgs.Empty);
        }
        #endregion
    }
}

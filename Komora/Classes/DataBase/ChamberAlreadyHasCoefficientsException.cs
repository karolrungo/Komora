using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komora.Classes.DataBase
{
    class ChamberAlreadyHasCoefficientsException : Exception
    {
        private string message;
        public override string Message { get{return message;} }

        public ChamberAlreadyHasCoefficientsException(string message)
        {
            this.message = message;
        }
    }
}

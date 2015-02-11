using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komora.Classes.DataBase
{
    class DatabaseConnectionException : Exception
    {
        private string message;

        public DatabaseConnectionException(string message)
        {
            // TODO: Complete member initialization
            this.message = message;
        }
    }
}

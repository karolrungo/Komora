﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataBase
{
    public class LinqDataBaseConnector : IDataBaseConnector
    {
        #region Private Variables
        //databaseconteext - trzeba utworzyc baze danych
        #endregion

        #region Public Methods
        bool IDataBaseConnector.Connect()
        {
            throw new NotImplementedException();
        }
        bool IDataBaseConnector.Disconnect()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Matlab
{
    public interface IMatlabConnection
    {
        void exectuteStatement(string statement);
    }
}

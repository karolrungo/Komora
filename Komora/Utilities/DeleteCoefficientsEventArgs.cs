using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Utilities
{
    public class DeleteCoefficientsEventArgs : EventArgs
    {
        public string coefficientsID;
        public CoefficientsType coefficientsType;

        public DeleteCoefficientsEventArgs(string ID, CoefficientsType coefficientsType)
        {
            this.coefficientsID = ID;
            this.coefficientsType = coefficientsType;
        }
    }
}

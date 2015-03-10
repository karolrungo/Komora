using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Utilities
{
    public class DeleteCoefficientsEventArgs : EventArgs
    {
        public int coefficientsID;
        public CoefficientsType coefficientsType;

        public DeleteCoefficientsEventArgs(int ID, CoefficientsType coefficientsType)
        {
            this.coefficientsID = ID;
            this.coefficientsType = coefficientsType;
        }

        public DeleteCoefficientsEventArgs(CoefficientsType coefficientsType)
        {
            this.coefficientsType = coefficientsType;
        }
    }
}

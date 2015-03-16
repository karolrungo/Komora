using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komora.Utilities
{
    public class SaveCoefficientsEventArgs : EventArgs
    {
        public int chamberID;
        public CoefficientsType coefficientsType;

        public SaveCoefficientsEventArgs(int ID, CoefficientsType coefficientsType)
        {
            this.chamberID = ID;
            this.coefficientsType = coefficientsType;
        }

        public SaveCoefficientsEventArgs(CoefficientsType coefficientsType)
        {
            this.coefficientsType = coefficientsType;
        }
    }
}

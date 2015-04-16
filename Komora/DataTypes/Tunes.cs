using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public class Tunes
    {
        public int kp;
        public int ki;
        public int kd;
        public int scal;

        public Tunes()
        {
            kp = int.MinValue;
            ki = int.MinValue;
            kd = int.MinValue;
            scal = 1000;
        }

        public override string ToString()
        {
            return "kp= " + (Convert.ToDouble(kp) / scal).ToString() +
                   ", ki= " + (Convert.ToDouble(ki) / scal).ToString() +
                   ", kd= " + (Convert.ToDouble(kd) / scal).ToString() +
                   ", scal= " + scal.ToString();
        }

        public static bool operator ==(Tunes tunes1, Tunes tunes2)
        {

            if (System.Object.ReferenceEquals(tunes1, tunes2))
            {
                return true;
            }

            if (((object)tunes1 == null) || ((object)tunes2 == null))
            {
                return false;
            }

            bool a =  tunes1.kp == tunes2.kp &&
                   tunes1.ki == tunes2.ki &&
                   tunes1.kd == tunes2.kd &&
                   tunes1.scal == tunes2.scal;
            return a;
        }

        public static bool operator !=(Tunes tunes1, Tunes tunes2)
        {
            return !(tunes1==tunes2);
        }

        public bool Equals(Tunes tunes2)
        {
            if (tunes2 == null)
            {
                return false;
            }
            else
            {
                return this == tunes2;
            }
        }
    }
}

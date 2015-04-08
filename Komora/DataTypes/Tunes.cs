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
    }
}

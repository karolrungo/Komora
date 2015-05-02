using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public class RegulationParameters
    {
        public double sp;
        public double cv;
        public double pv;
        public double err;
        public DateTime dateTime;

        public RegulationParameters()
        {
            sp = double.MinValue;
            cv = double.MinValue;
            pv = double.MinValue;
            err = double.MinValue;
            dateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return "SP= "+sp.ToString()+", CV= "+cv.ToString()+", PV= "+pv.ToString()+", ERR= "+err.ToString();
        }

        public string PV 
        {
            get
            {
                if (pv != double.MinValue)
                    return pv.ToString("0.000");
                else
                    return "NO DATA";
            }
        }

        public string SP
        {
            get
            {
                if (pv != double.MinValue)
                    return sp.ToString("0.000");
                else
                    return "NO DATA";
            }
        }
    }
}

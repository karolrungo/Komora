using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public class Hardware_Conf
    {
        //wartosc napiecia referencyjnego (0-4095)
        public int atmega_aref;
        //wartosc rezystancji rezystora wzorcowego przy pt100
        public int pt100_ref_res; 
    }
}

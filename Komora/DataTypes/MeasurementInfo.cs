using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public class MeasurementInfo
    {
        public string measurementName;
        public string filename;
        public double weight;
        public string material;
        public string basicAdditionalInfo;
        public string laboratory;
        public DateTime synthesisDate;
        public string _operator;
        public bool afterRejuvenation;
        public DateTime rejuvenationTime;
        public string rejuvenationAdditionalInfo;
        public string darkAged;
        public string specialAged;
    }
}

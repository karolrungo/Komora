using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Utilities
{
    public class CoefficientsStringFormatter
    {
        private List<string> splittedCoefficients;
        private string coefficientsString;

        public CoefficientsStringFormatter(string source)
        {
            coefficientsString = source;
        }

        public string formatString()
        {
            splittedCoefficients = getRevertedListOfCoefficients();
            StringBuilder outputString = new StringBuilder();

            int power = splittedCoefficients.Count - 1;
            for (int i = 0; i < splittedCoefficients.Count; i++)
            {
                if (power > 1)
                {
                    outputString.Append(splittedCoefficients[i] + "x^" + power.ToString() + " + ");
                    
                }
                if (power == 1)
                {
                    outputString.Append(splittedCoefficients[i] + "x + ");
                }
                if (power == 0)
                {
                    outputString.Append(splittedCoefficients[i]);
                }               
                power--;
            }

            return outputString.ToString();
        }

        public List<string> getRevertedListOfCoefficients()
        {
            char separator = ':';
            return coefficientsString.Split(separator).Reverse().ToList();
        }
    }
}

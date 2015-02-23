using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Tools
{
    public static class DateCounter
    {
        public static TimeSpan calculateDifferenceBetweenDates(DateTime begin, DateTime end)
        {
            return (begin - end);
        }
    }
}

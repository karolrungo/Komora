using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.Controls
{
    public partial class DateAndTimePicker : UserControl
    {
        public DateAndTimePicker()
        {
            InitializeComponent();
        }

        public DateTime getDateAndTime()
        {
            DateTime date = dateTimePickerDate.Value;
            DateTime time = dateTimePickerTime.Value;

            return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
        }
    }
}

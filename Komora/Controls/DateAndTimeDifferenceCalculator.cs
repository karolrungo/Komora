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
    public partial class DateAndTimeDifferenceCalculator : UserControl
    {
        public DateAndTimeDifferenceCalculator()
        {
            InitializeComponent();
            labelResult.Text = "";
        }

        private void calculateTimeDifference()
        {
            DateTime start = dateAndTimePickerStart.getDateAndTime();
            DateTime end = dateAndTimePickerEnd.getDateAndTime();
            TimeSpan diff  = start.Subtract(end.Date).Subtract(end.TimeOfDay);

            labelResult.Text = formatOutputString(diff);
        }
        private string formatOutputString(TimeSpan result)
        {
            StringBuilder dateDiffString = new StringBuilder();
            dateDiffString.Append("Difference beetween dates is: ").Append(Environment.NewLine);
            dateDiffString.Append(result.Days).Append(" days ");
            dateDiffString.Append(result.Minutes).Append(" minutes ");
            dateDiffString.Append(result.Seconds).Append(" seconds ");
            return dateDiffString.ToString();
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            calculateTimeDifference();
        }
    }
}

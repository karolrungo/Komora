using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Windows.LoginWindow());
            Application.Run(new Windows.MatlabWndow());
            //Application.Run(new Windows.MeasurementConfigurationWindow());

            //DataTypes.MeasurementInfo measInfo = new DataTypes.MeasurementInfo();
            //measInfo.measurementName = "MeasurementName";
            //Application.Run(new Windows.MeasurementForm("COM4", 6, measInfo));
        }
    }
}

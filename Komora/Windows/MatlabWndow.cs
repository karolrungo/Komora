using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.Windows
{
    public partial class MatlabWndow : Form
    {
        private string filename;
        private double iseResult;
        private Classes.File.MeasurementFileManager measurementFileManager;
        private Classes.Matlab.IMatlabConnector matlabComServer;

        public MatlabWndow()
        {
            InitializeComponent();
            textBoxFilename.Text = @"D:\Repositories\Komora\Komora\bin\Debug\MEAS\data.csv";
            filename = @"D:\Repositories\Komora\Komora\bin\Debug\MEAS\data.csv";

            matlabComServer = new Classes.Matlab.MatlabCOMSerwer();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                textBoxFilename.Text = filename;
            }
            else
            {
                MessageBox.Show("There is a problem with selected file");
            }
        }

        private void buttonLaunchMatlab_Click(object sender, EventArgs e)
        {
            measurementFileManager = new Classes.File.MeasurementFileManager();
            List<double> errorValues = measurementFileManager.getErrorValuesFromFile(filename);
            List<double> timeDeltaValues = measurementFileManager.getTimeDeltaFromFile(filename);

            matlabComServer.connect();
            matlabComServer.exectuteStatement(@"D:\Repositories\Komora\matlabScripts", errorValues, timeDeltaValues);
            matlabComServer.disconnect();
        }

    }
}

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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public delegate void LoginWindowVisibility(object sender, EventArgs e);
        public event LoginWindowVisibility showWindow;
        public void RaiseShowLoginWindowEvent(EventArgs e)
        {
            if (showWindow != null)
            {
                showWindow(this, EventArgs.Empty);
            }
        }

        private void btnMatlab_Click(object sender, EventArgs e)
        {
            MatlabWndow matlabWindow = new MatlabWndow();
            matlabWindow.Show();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            ToolsWindow toolsWindow = new ToolsWindow();
            toolsWindow.Show();
        }

        private void buttonCalibration_Click(object sender, EventArgs e)
        {
            CalibrationWindow calibrationWindow = new CalibrationWindow();
            calibrationWindow.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }
    }
}

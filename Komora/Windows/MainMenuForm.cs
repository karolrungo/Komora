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

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RaiseShowLoginWindowEvent(EventArgs.Empty);
        }

        #region Events & Delegates
        public delegate void LoginWindowVisibility(object sender, EventArgs e);
        public event LoginWindowVisibility showWindow;
        #endregion

        public void RaiseShowLoginWindowEvent(EventArgs e)
        {
            if (showWindow != null)
            {
                showWindow(this, EventArgs.Empty);
            }
        }
    }
}

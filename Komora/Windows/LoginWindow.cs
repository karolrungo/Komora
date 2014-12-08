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
    public partial class LoginWindow : Form
    {
        #region Private Variables
        Komora.Classes.DataBase.IDataBaseConnector dataBaseConnector;
        #endregion

        public LoginWindow()
        {
            dataBaseConnector = new Komora.Classes.DataBase.LinqDataBaseConnector();
            InitializeComponent();
        }

    }
}

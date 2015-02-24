using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Classes.DataBase;

namespace Komora.Windows
{
    public partial class SettingsWindow : Form
    {
        private IDataBaseConnector linqDatabaseConnector;

        public SettingsWindow()
        {
            linqDatabaseConnector = new LinqDataBaseConnector();
            linqDatabaseConnector.connect();

            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.DataSource = linqDatabaseConnector.selectAllChambers();
        }
    }
}

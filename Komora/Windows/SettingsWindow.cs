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
        private string chamberName;
        private string chamberNumber;
        private string serialPort;

        public SettingsWindow()
        {
            linqDatabaseConnector = new LinqDataBaseConnector();
            linqDatabaseConnector.connect();

            InitializeComponent();
            dataGridViewChambers.ReadOnly = true;
            dataGridViewChambers.AllowUserToAddRows = false;
            dataGridViewChambers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewChambers.DataSource = linqDatabaseConnector.selectAllChambers();
        }

        private void btnDeleteChamber_Click(object sender, EventArgs e)
        {

        }

        private void btnEditChamber_Click(object sender, EventArgs e)
        {

        }

        private void btnAddChamber_Click(object sender, EventArgs e)
        {

        }

        private bool onlyOneRowSelected()
        {
            return (dataGridViewChambers.SelectedRows.Count == 1) ? true : false;
        }

        private void dataGridViewChambers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (onlyOneRowSelected())
            {
                chamberName = dataGridViewChambers.SelectedRows[0].Cells["chamberName"].Value.ToString();
                chamberNumber = dataGridViewChambers.SelectedRows[0].Cells["chamberNumber"].Value.ToString();
                serialPort = dataGridViewChambers.SelectedRows[0].Cells["serialPort"].Value.ToString();

                textBoxHardwareConfChamberName.Text = chamberName;
                comboBoxHardwareConfChamberNumber.Text = chamberNumber;
                textBoxHardwareConfSerialPortName.Text = serialPort;
            }
        }
    }
}

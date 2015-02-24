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
using Komora.Classes.Chamber;

namespace Komora.Windows
{
    public partial class SettingsWindow : Form
    {
        private ChamberData chamberData;
        private IDataBaseConnector linqDatabaseConnector;

        public SettingsWindow()
        {
            chamberData = new ChamberData();
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
            try
            {
                //walidator portu szeregowego
                chamberData.setChamberData(textBoxHardwareConfChamberName.Text,
                                           textBoxHardwareConfSerialPortName.Text,
                                           Int32.Parse(comboBoxHardwareConfChamberNumber.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wrong data! Correct yourself.");
            }

            //czy tu try catch?
            linqDatabaseConnector.deleteChamber(chamberData);
        }

        private void btnEditChamber_Click(object sender, EventArgs e)
        {

        }

        private void btnAddChamber_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewChambers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (onlyOneRowSelected())
            {
                fillTextBoxesWithChamberDataFromDataGridViewRow();
            }
        }

        private void fillTextBoxesWithChamberDataFromDataGridViewRow()
        {
            chamberData.Name = dataGridViewChambers.SelectedRows[0].Cells["chamberName"].Value.ToString();
            chamberData.SerialPort = dataGridViewChambers.SelectedRows[0].Cells["chamberNumber"].Value.ToString();
            chamberData.Number = Int32.Parse(dataGridViewChambers.SelectedRows[0].Cells["serialPort"].Value.ToString());

            textBoxHardwareConfChamberName.Text = chamberData.Name;
            comboBoxHardwareConfChamberNumber.Text = chamberData.SerialPort;
            textBoxHardwareConfSerialPortName.Text = chamberData.Number.ToString();
        }
        private bool onlyOneRowSelected()
        {
            return (dataGridViewChambers.SelectedRows.Count == 1) ? true : false;
        }
    }
}

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
        private Classes.Communication.SerialPortWatcher serialPortWatcher;

        //do odswiezania textboxa z podlaczaonymi portami COM
        public delegate void UpdateTextCallback(string text);


        public SettingsWindow()
        {
            chamberData = new ChamberData();
            
            linqDatabaseConnector = new LinqDataBaseConnector();
            linqDatabaseConnector.connect();

            serialPortWatcher = new Classes.Communication.SerialPortWatcher(2000);
            serialPortWatcher.comPortsUpdate += serialPortWatcher_comPortsUpdate;

            InitializeComponent();

            dataGridViewChambers.ReadOnly = true;
            dataGridViewChambers.AllowUserToAddRows = false;
            dataGridViewChambers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewChambers.DataSource = linqDatabaseConnector.selectAllChambers();

        }

        private void serialPortWatcher_comPortsUpdate(object sender, Classes.Communication.SerialPortWatcherEventArgs e)
        {
            textBoxAvaliblePorts.Multiline = true;
            textBoxAvaliblePorts.Invoke((MethodInvoker)delegate { textBoxAvaliblePorts.Text = showAvalibleComPorts(e.comPorts); });
        }

        private void UpdateText(string text)
        {
            textBoxAvaliblePorts.Text = text;
        }

        private string showAvalibleComPorts(List<string> comPorts)
        {
            StringBuilder sb = new StringBuilder("Avalible ports");
            foreach (string port in comPorts)
            {
                sb.Append(Environment.NewLine).Append(port);
            }
            return sb.ToString();
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
            chamberData.SerialPort = dataGridViewChambers.SelectedRows[0].Cells["serialPort"].Value.ToString();
            chamberData.Number = Int32.Parse(dataGridViewChambers.SelectedRows[0].Cells["chamberNumber"].Value.ToString());

            textBoxHardwareConfChamberName.Text = chamberData.Name;
            comboBoxHardwareConfChamberNumber.Text = chamberData.SerialPort;
            textBoxHardwareConfSerialPortName.Text = chamberData.Number.ToString();
        }

        private bool onlyOneRowSelected()
        {
            return (dataGridViewChambers.SelectedRows.Count == 1) ? true : false;
        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPortWatcher.stopTimer();
        }
    }
}

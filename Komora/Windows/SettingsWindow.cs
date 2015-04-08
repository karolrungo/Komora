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
        private Classes.Communication.SerialPortWatcher serialPortWatcher;

        //do odswiezania textboxa z podlaczaonymi portami COM
        public delegate void UpdateTextCallback(string text);


        public SettingsWindow()
        {
       
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

        private void btnAddChamber_Click(object sender, EventArgs e)
        {
            try
            {
                linqDatabaseConnector.addChamber(textBoxHardwareConfChamberName.Text,
                                                 textBoxHardwareConfSerialPortName.Text,
                                                 Int32.Parse(comboBoxHardwareConfChamberNumber.Text));
                dataGridViewChambers.DataSource = linqDatabaseConnector.selectAllChambers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteChamber_Click(object sender, EventArgs e)
        {
            try
            {
                linqDatabaseConnector.deleteChamber(textBoxHardwareConfChamberName.Text,
                                                    textBoxHardwareConfSerialPortName.Text,
                                                    Int32.Parse(comboBoxHardwareConfChamberNumber.Text));
                dataGridViewChambers.DataSource = linqDatabaseConnector.selectAllChambers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            textBoxHardwareConfChamberName.Text = dataGridViewChambers.SelectedRows[0].Cells["chamberName"].Value.ToString();
            textBoxHardwareConfSerialPortName.Text = dataGridViewChambers.SelectedRows[0].Cells["serialPort"].Value.ToString();
            comboBoxHardwareConfChamberNumber.Text = dataGridViewChambers.SelectedRows[0].Cells["chamberNumber"].Value.ToString();
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

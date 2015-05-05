using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Controls;
using Komora.Classes.Segment;


namespace Komora.Windows
{
    public partial class MeasurementConfigurationWindow : Form
    {
        private const int oneSecond = 1000;
        private Classes.DataBase.LinqDataBaseConnector databaseConnector;
        private DataTypes.MeasurementInfo measurementInfo;
        private Classes.Communication.SerialPortValidator serialPortValidator;
        private Classes.Communication.SerialPortWatcher serialPortWatcher;
        private SegmentFactory segmentFactory;
        private SegmentData segmentData;
        private SegmentList segmentList;

        public MeasurementConfigurationWindow()
        {
            InitializeComponent();

            serialPortValidator = new Classes.Communication.SerialPortValidator();
            serialPortWatcher = new Classes.Communication.SerialPortWatcher(oneSecond);
            serialPortWatcher.comPortsUpdate += serialPortWatcher_comPortsUpdate;
            databaseConnector = new Classes.DataBase.LinqDataBaseConnector();
            databaseConnector.connect();
            measurementInfo = new DataTypes.MeasurementInfo();
            segmentFactory = new SegmentFactory();
            segmentData = new SegmentData();
            segmentList = new SegmentList();

            dgvChambers.DataSource = databaseConnector.selectCalibratedChambers();

            segmentInterfaceControl.ButtonAddClicked += segmentInterfaceControl_ButtonAddClicked;
            segmentInterfaceControl.ButtonDeleteClicked += segmentInterfaceControl_ButtonDeleteClicked;
            segmentInterfaceControl.ButtonEditClicked += segmentInterfaceControl_ButtonEditClicked;
            segmentInterfaceControl.ButtonClearListClicked += segmentInterfaceControl_ButtonClearListClicked;
        }

        void segmentInterfaceControl_ButtonClearListClicked(object sender, EventArgs e)
        {
            SEGMENT_TYPE segmentType = segmentInterfaceControl.getSegmentType();
            segmentData = segmentInterfaceControl.getSegmentData();
            Segment segment = segmentFactory.createSegment(segmentType, segmentData);

        }

        void segmentInterfaceControl_ButtonEditClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void segmentInterfaceControl_ButtonDeleteClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void segmentInterfaceControl_ButtonAddClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnStartMeasurement_Click(object sender, EventArgs e)
        {
            try
            {
                string serialPort = getSerialPortFromDataGridView();
                int chamberID = getChamberIdFromDataGridView();

                measurementInfo = measurementInfoControl.getMeasurementInfo();
                databaseConnector.saveMeasurementInfo(measurementInfo);

                MeasurementForm measurementForm = new MeasurementForm(serialPort, chamberID, measurementInfo);
                measurementForm.Show(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int getChamberIdFromDataGridView()
        {
            if (onlyOneRowSelected(dgvChambers))
            {
                string chamberID = dgvChambers.SelectedRows[0].Cells["ID"].Value.ToString();

                return Int32.Parse(chamberID);
            }
            else
            {
                throw new Exception("Select only one chamber!");
            }
        }

        private string getSerialPortFromDataGridView()
        {
            if (onlyOneRowSelected(dgvChambers))
            {
                string serialPortName = dgvChambers.SelectedRows[0].Cells["serialPort"].Value.ToString();
                if (!serialPortValidator.portExists(serialPortName))
                {
                    throw new Exception("Port " + serialPortName + " does not exists!");
                }
                return serialPortName;
            }
            else
            {
                throw new Exception("Select only one chamber!");
            }
        }

        private bool onlyOneRowSelected(DataGridView dgv)
        {
            return (dgv.SelectedRows.Count == 1) ? true : false;
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
    }
}

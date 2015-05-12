using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Classes;
using Komora;
using Komora.DataTypes;
using System.Threading;
using ZedGraph;

namespace Komora.Windows
{
    public partial class MeasurementForm : Form
    {
        private const int ATMegaScaler = 100;
        private string serialPort;
        private readonly int chamberID;
        private DataTypes.ControllerValues controllerValues; //dane ze sterownika
        private Classes.Communication.AT_Command atCommand; //komendy AT
        private Classes.Communication.ParserThread parserThread; //parser danych przychodzacych ze sterownika (osobny watek)
        private DataTypes.MeasurementInfo measInfo;
        private Classes.DataBase.LinqDataBaseConnector databaseConnection;
        private Classes.Plot.ZedGraphController zedGraphController;
        private Utilities.Pt100converter pt100Converter;
        private Classes.Segment.SegmentList segmentList;

        private ZedGraph.PointPairList temperaturePoints;
        private ZedGraph.PointPairList temperatureDerivativePoints;
        private ZedGraph.PointPairList diodeCurrentPoints;


        public MeasurementForm(string serialPort, int chamberID, DataTypes.MeasurementInfo measInfo, Classes.Segment.SegmentList p_segmentList)
        {
            this.serialPort = serialPort;
            atCommand = new Classes.Communication.AT_Command(serialPort);
            controllerValues = new DataTypes.ControllerValues();
            this.chamberID = chamberID;
            this.measInfo = measInfo;
            segmentList = p_segmentList;
            segmentList.catchAcquisitionRateTimerTicks();
            segmentList.AcquisitionRateTimerTicked += segmentList_AcquisitionRateTimerTicked;

            InitializeComponent();

            parserThread = new Classes.Communication.ParserThread(atCommand.RecivedStrings, ref controllerValues);
            parserThread.sendRecivedCommandsEvent += parserThread_sendRecivedCommandsEvent;
            databaseConnection = new Classes.DataBase.LinqDataBaseConnector();
            databaseConnection.connect();

            pt100Converter = new Utilities.Pt100converter(databaseConnection.selectPt100Polynomial(chamberID).Coefficients,
                                                          ATMegaScaler);

            measurementInfoControl.setMeasurementInfo(databaseConnection.getMeasurementInfo(measInfo.measurementName));
            dgvSegmentList.DataSource = p_segmentList.ToDataTable();

            temperaturePoints = new PointPairList();
            temperatureDerivativePoints = new PointPairList();
            diodeCurrentPoints = new PointPairList();

            zedGraphController = new Classes.Plot.ZedGraphController(ref plot);
            zedGraphController.configureMeasurementPlot();

            atCommand.AT_CONT_MODE(CONT_MODE.FEEDBACK);
            Thread.Sleep(300);
            atCommand.AT_CONTROL_MODE(CONTROL_MODE.BOTH);
            Thread.Sleep(300);
            atCommand.AT_AUTO_SENDER_DATA(true);
            atCommand.AT_DISPLAY_MODE(DISPLAY_MODE.INFO);
            segmentList.setControllerValues(ref controllerValues);
            segmentList.setAtCommands(ref atCommand);
            segmentList.setPt100Converter(pt100Converter);
            segmentList.AddSegmentFinishedEventForeachSegment();
            segmentList.Start();

            //atCommand.AT_CONTR_SEGMENT(5);
          //  atCommand.AT_HEATER_PARAMS_READ();
        }

        private void parserThread_sendRecivedCommandsEvent(object sender, Classes.Communication.RecivedCommandsEventArgs e)
        {
            foreach (string command in e.recivedCommands)
            {
                addItemToListBox(listBoxCommands, command);
            }
        }

        private void addItemToListBox(ListBox listBox, string command)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(new MethodInvoker(delegate
                {
                    listBox.Items.Add(command);
                }));
            }
            else
            {
                listBox.Items.Add(command);
            } 
        }

        private void MeasurementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            atCommand.AT_CONT_MODE(CONT_MODE.IDLE);
            Thread.Sleep(300);
            atCommand.AT_CONTROL_MODE(CONTROL_MODE.OFF);
            Thread.Sleep(300);
            atCommand.AT_AUTO_SENDER_DATA(false);

            parserThread.Stop();
            atCommand.CancelSerialPortDataRecivedHandler();
            atCommand.CloseSerialPort();
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            listBoxCommands.Items.Clear();
            atCommand.ATI();
        }

        void segmentList_AcquisitionRateTimerTicked(object sender, EventArgs e)
        {
            updatePlot();
        }

        private void updatePlot()
        {
            temperaturePoints.Add(new PointPair(new XDate(controllerValues.heater_Params.dateTime),
                                                controllerValues.heater_Params.pv));

            temperatureDerivativePoints = Classes.Algorithm.DerivativeCalculator.calculate(temperaturePoints);

            diodeCurrentPoints.Add(new PointPair(new XDate(controllerValues.diode_Params.dateTime),
                                                controllerValues.diode_Params.pv));

            zedGraphController.DrawLines(temperaturePoints, temperatureDerivativePoints, diodeCurrentPoints);
        }
    }
}

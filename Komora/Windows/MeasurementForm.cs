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
        private Classes.Communication.LcdController lcdController;
        private Classes.File.MeasurementFileManager measurementFileManager;

        private ZedGraph.PointPairList temperaturePoints;
        private ZedGraph.PointPairList temperatureDerivativePoints;
        private ZedGraph.PointPairList diodeCurrentPoints;


        public MeasurementForm(string serialPort, int chamberID, DataTypes.MeasurementInfo measInfo, Classes.Segment.SegmentList p_segmentList)
        {
            this.serialPort = serialPort;
            this.chamberID = chamberID;
            this.measInfo = measInfo;
            segmentList = p_segmentList;
            segmentList.catchAcquisitionRateTimerTicks();
            segmentList.AcquisitionRateTimerTicked += segmentList_AcquisitionRateTimerTicked;

            InitializeComponent();

            atCommand = new Classes.Communication.AT_Command(serialPort);
            controllerValues = new DataTypes.ControllerValues();

            parserThread = new Classes.Communication.ParserThread(atCommand.RecivedStrings, ref controllerValues);
            parserThread.sendRecivedCommandsEvent += parserThread_sendRecivedCommandsEvent;

            databaseConnection = new Classes.DataBase.LinqDataBaseConnector();
            databaseConnection.connect();

            lcdController = new Classes.Communication.LcdController(ref atCommand, ref controllerValues);

            pt100Converter = new Utilities.Pt100converter(databaseConnection.selectPt100Polynomial(chamberID).Coefficients,
                                                          ATMegaScaler);
            measurementFileManager = new Classes.File.MeasurementFileManager(measInfo.filename);

            measurementInfoControl.setMeasurementInfo(databaseConnection.getMeasurementInfo(measInfo.measurementName));
            dgvSegmentList.DataSource = p_segmentList.ToDataTable();

            temperaturePoints = new PointPairList();
            temperatureDerivativePoints = new PointPairList();
            diodeCurrentPoints = new PointPairList();

            zedGraphController = new Classes.Plot.ZedGraphController(ref plot);
            zedGraphController.configureMeasurementPlot();
            plot.GraphPane.Title.Text = "Measurement plot";

            measurementFileManager.deleteFile();
            measurementFileManager.createFileIfNotExists();

            atCommand.AT_CONT_MODE(CONT_MODE.FEEDBACK);
            Thread.Sleep(300);
            atCommand.AT_CONTROL_MODE(CONTROL_MODE.HEATER);
            Thread.Sleep(300);
            atCommand.AT_AUTO_SENDER_DATA(true);
            atCommand.AT_DISPLAY_MODE(DISPLAY_MODE.INFO);
            segmentList.setControllerValues(ref controllerValues);
            segmentList.setAtCommands(ref atCommand);
            segmentList.setPt100Converter(pt100Converter);
            segmentList.AddSegmentFinishedEventForeachSegment();
            segmentList.Start();
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
            atCommand.sender = tbCommand.Text;
            atCommand.SendAT_Command();
        }

        void segmentList_AcquisitionRateTimerTicked(object sender, Classes.Segment.SegmentEventArgs e)
        {
            string format = "0.00";
            double pv = pt100Converter.resistanceToTemperature(controllerValues.heater_Params.pv);
            double sp = pt100Converter.resistanceToTemperature(controllerValues.heater_Params.sp);
            double err = sp - pv;
            string date = String.Format("{0:d/M/yyyy HH/mm/ss}", controllerValues.heater_Params.dateTime);

            labelPV.Invoke((MethodInvoker)delegate { labelPV.Text = pv.ToString(format); });
            labelSP.Invoke((MethodInvoker)delegate { labelSP.Text = sp.ToString(format); });
            labelERR.Invoke((MethodInvoker)delegate { labelERR.Text = err.ToString(format); });

            updatePlot();
            measurementFileManager.writeDataToFile(e.actualSegment,
                                                   e.sEGMENT_TYPE,
                                                   pv.ToString(format),
                                                   sp.ToString(format),
                                                   (sp - pv).ToString(format),
                                                   date);
        }

        private void updatePlot()
        {
            temperaturePoints.Add(new PointPair(new XDate(controllerValues.heater_Params.dateTime),
                                                pt100Converter.resistanceToTemperature(controllerValues.heater_Params.pv)));

            temperatureDerivativePoints = Classes.Algorithm.DerivativeCalculator.calculate(temperaturePoints);

            diodeCurrentPoints.Add(new PointPair(new XDate(controllerValues.diode_Params.dateTime),
                                                controllerValues.diode_Params.pv));

            zedGraphController.DrawLines(temperaturePoints, temperatureDerivativePoints, diodeCurrentPoints);
        }

        private void btnLcdScreenMinus_Click(object sender, EventArgs e)
        {
            lcdController.lcdPreviousScreen();
        }

        private void btnLcdScreenPlus_Click(object sender, EventArgs e)
        {
            lcdController.lcdNextScreen();
        }

        private void btnLCD_on_off_Click(object sender, EventArgs e)
        {
            lcdController.setLcdBackground();
        }

        private void sliderLcdContr_ValueChanged(object sender, EventArgs e)
        {
            lcdController.setLcdCotrast(sliderLcdContr.Value);
        }

        private void comboBoxTimeDisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lcdController.changeTimeDisplayMode(comboBoxTimeDisplayMode.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lcdController.changeLedBargraphMode(comboBoxLedBargraph.SelectedItem.ToString());
        }
    }
}

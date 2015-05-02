using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora;
using System.Threading;

namespace Komora.Windows
{
    public partial class PidTunesForm : Form
    {
        private DataTypes.Tunes heaterTunes;
        private DataTypes.Tunes diodeTunes;
        private Classes.Communication.AT_Command atCommand;
        private DataTypes.ControllerValues controllerValues;
        private Classes.Communication.ParserThread parserThread;


        public PidTunesForm(string serialPortName)
        {
            InitializeComponent();

            heaterTunes = new DataTypes.Tunes();
            diodeTunes = new DataTypes.Tunes();
            controllerValues = new DataTypes.ControllerValues();

            atCommand = new Classes.Communication.AT_Command(serialPortName);
            parserThread = new Classes.Communication.ParserThread(atCommand.RecivedStrings, ref controllerValues);
        }

        private void btnLoadTunes_Click(object sender, EventArgs e)
        {
            atCommand.AT_PID_HEATER_TUNES_READ();
            Thread.Sleep(200);

            tbHeaterKP.Text = (Convert.ToDouble(controllerValues.heater_Tunes.kp) / controllerValues.heater_Tunes.scal).ToString();
            tbHeaterKI.Text = (Convert.ToDouble(controllerValues.heater_Tunes.ki) / controllerValues.heater_Tunes.scal).ToString();
            tbHeaterKD.Text = (Convert.ToDouble(controllerValues.heater_Tunes.kd) / controllerValues.heater_Tunes.scal).ToString();
            tbHeaterScal.Text = controllerValues.heater_Tunes.scal.ToString();

            atCommand.AT_PID_DIODE_TUNES_READ();
            Thread.Sleep(200);
            tbDiodeKP.Text = (Convert.ToDouble(controllerValues.diode_Tunes.kp) / controllerValues.diode_Tunes.scal).ToString();
            tbDiodeKI.Text = (Convert.ToDouble(controllerValues.diode_Tunes.ki) / controllerValues.diode_Tunes.scal).ToString();
            tbDiodeKD.Text = (Convert.ToDouble(controllerValues.diode_Tunes.kd) / controllerValues.diode_Tunes.scal).ToString();
            tbDiodeScal.Text = controllerValues.diode_Tunes.scal.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            diodeTunes = new DataTypes.Tunes();
            heaterTunes = new DataTypes.Tunes();

            try
            {
                heaterTunes.kp = Convert.ToInt32(Double.Parse(tbHeaterKP.Text) * Double.Parse(tbHeaterScal.Text));
                heaterTunes.ki = Convert.ToInt32(Double.Parse(tbHeaterKI.Text) * Double.Parse(tbHeaterScal.Text));
                heaterTunes.kd = Convert.ToInt32(Double.Parse(tbHeaterKD.Text) * Double.Parse(tbHeaterScal.Text));
                heaterTunes.scal = Int32.Parse(tbHeaterScal.Text);

                diodeTunes.kp = Convert.ToInt32(Double.Parse(tbDiodeKP.Text) * Double.Parse(tbDiodeScal.Text));
                diodeTunes.ki = Convert.ToInt32(Double.Parse(tbDiodeKI.Text) * Double.Parse(tbDiodeScal.Text));
                diodeTunes.kd = Convert.ToInt32(Double.Parse(tbDiodeKD.Text) * Double.Parse(tbDiodeScal.Text));
                diodeTunes.scal = Int32.Parse(tbDiodeScal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong tunes! Try again.");
                return;
            }

            try
            {
                atCommand.AT_PID_HEATER_TUNES(heaterTunes.kp, heaterTunes.ki, heaterTunes.kd, heaterTunes.scal);
                atCommand.AT_PID_DIODE_TUNES(diodeTunes.kp, diodeTunes.ki, diodeTunes.kd, diodeTunes.scal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PidTunesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parserThread.Stop();
        }
    }
}

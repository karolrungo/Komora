using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komora.Classes.Segment
{
    public abstract class Segment
    {
        private const int oneSecond = 1000;
        public SEGMENT_STATUS segmentStatus;
        public SEGMENT_TYPE segmentType;
        public int durationTimeSeconds;
        public DateTime startTime;
        public DateTime endTime;
        public System.Timers.Timer timer1000ms;
        public System.Timers.Timer timerAcquisitionRate;
        public double acquisitionRateSeconds;
        public double acquisitionRateMinutes;
        public double heatingRateSeconds;
        public double heatingRateMinutes;
        public double startTemperature, endTemperature;
        public DataTypes.ControllerValues controllerValues; // zmienna wspoldzielona z parserem i oknem pomiarowym
        public Classes.Communication.AT_Command atCommand;
        public Utilities.Pt100converter pt100Converter;

        public bool ledON;
        public double ledCurrent;

        public event EventHandler SegmentFinished;
        public event EventHandler AcquisitionRateTimerTicked;

        public Segment() { }

        public Segment(int time, double acquisitionRate)
        {
            segmentStatus = SEGMENT_STATUS.WAITING;

            durationTimeSeconds = time;

            startTime = new DateTime();
            endTime = new DateTime();
            startTime = DateTime.Now;
            endTime = startTime.AddSeconds(time);

            this.acquisitionRateMinutes = acquisitionRate;
            this.acquisitionRateSeconds = acquisitionRate / 60;
            double interval = 1 / this.acquisitionRateSeconds * oneSecond;

            timer1000ms = new System.Timers.Timer(oneSecond); //timer do sprawdzania czau konca sekwencji
            timerAcquisitionRate = new System.Timers.Timer(interval);
            timerAcquisitionRate.Elapsed += timerAcquisitionRate_Elapsed;
        }

        private void timerAcquisitionRate_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //MessageBox.Show("acqRate Ticked" + pt100Converter.resistanceToTemperature(Convert.ToInt64(controllerValues.heater_Params.pv/100)).ToString());
            //MessageBox.Show("acqRate Ticked" + controllerValues.heater_Params.pv.ToString());
            if (AcquisitionRateTimerTicked != null)
                AcquisitionRateTimerTicked(this, EventArgs.Empty);
        }

        public virtual void Start()
        {
            segmentStatus = SEGMENT_STATUS.PROCESSING;
            timerAcquisitionRate.Start();
        }
        public virtual void Finish()
        {
            segmentStatus = SEGMENT_STATUS.DONE;

            timer1000ms.Stop();
            timer1000ms.Enabled = false;
            timerAcquisitionRate.Stop();
            timerAcquisitionRate.Enabled = false;
            SegmentFinished(this, new EventArgs());
        }

        public abstract object[] DataTableRow();
    }
}

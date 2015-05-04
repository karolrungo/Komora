using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using ZedGraph;

namespace Komora.Controls
{
    public partial class CalibrationControl : UserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public delegate void DeleteCoefficientsButtonEventHandler(object sender, Utilities.DeleteCoefficientsEventArgs e);
        public delegate void SaveCoefficientsButtonEventHandler(object sender, Utilities.SaveCoefficientsEventArgs e);
        public event ButtonClickedEventHandler BrovseFileButtonClicked;
        public event DeleteCoefficientsButtonEventHandler BeginCalibrationButtonClicked;
        public event DeleteCoefficientsButtonEventHandler DeleteAllCoefficientsButtonClicked;
        public event DeleteCoefficientsButtonEventHandler DeleteSelectedCoefficientsButtonClicked;
        public event SaveCoefficientsButtonEventHandler SaveCoefficientsButtonClicked;

        private string filename;
        private Utilities.CoefficientsType coefficientsType;
        private Utilities.CoefficientsStringFormatter formatter;
        private Classes.Plot.ZedGraphController zedgraphController;

        public CalibrationControl()
        {
            InitializeComponent();
            zedgraphController = new Classes.Plot.ZedGraphController(ref calibrationPlot);
            coefficientsType = Utilities.CoefficientsType.PT100;
        }

        private void buttonBrowseFilePt100_Click(object sender, EventArgs e)
        {
            if(BrovseFileButtonClicked != null)
                BrovseFileButtonClicked(this, EventArgs.Empty);

            setFilenameFromOpenFileDialog();
        }

        private void buttonBeginCalibration_Click(object sender, EventArgs e)
        {
            if (BeginCalibrationButtonClicked != null)
                BeginCalibrationButtonClicked(this,
                                              new Utilities.DeleteCoefficientsEventArgs(coefficientsType));
        }

        private void buttonDeleteSelectedCoefficients_Click(object sender, EventArgs e)
        {
            if(onlyOneRowSelected(dataGridViewPolynomial))
            {
                if (DeleteSelectedCoefficientsButtonClicked != null)
                {
                    DeleteSelectedCoefficientsButtonClicked(this, 
                                                            new Utilities.DeleteCoefficientsEventArgs(Int32.Parse(dataGridViewPolynomial.SelectedRows[0].Cells["ID"].Value.ToString()),
                                                                                                      coefficientsType));
                }
            }
        }

        private void buttonDeleteAllCoefficients_Click(object sender, EventArgs e)
        {
            if (DeleteAllCoefficientsButtonClicked != null)
            {
                DeleteAllCoefficientsButtonClicked(this,
                                                   new Utilities.DeleteCoefficientsEventArgs(coefficientsType));
            }
        }

        private void buttonSaveCoefficients_Click(object sender, EventArgs e)
        {
            if (onlyOneRowSelected(dataGridViewChambers))
            {
                if (SaveCoefficientsButtonClicked != null)
                {
                    SaveCoefficientsButtonClicked(this,
                                                  new Utilities.SaveCoefficientsEventArgs(Int32.Parse(dataGridViewChambers.SelectedRows[0].Cells["ID"].Value.ToString()),
                                                                                          coefficientsType));
                }
            }
        }

        public void setPlotTitles(string graphTitle, string xaxisTitle, string yaxisTitle)
        {
            setPlotTitle(graphTitle);
            setPlotXAxisTitle(xaxisTitle);
            setPlotYAxisTitle(yaxisTitle);
        }

        private void setPlotTitle(string graphTitle)
        {
            calibrationPlot.GraphPane.Title.Text = graphTitle;
        }

        private void setPlotXAxisTitle(string xaxisTitle)
        {
            calibrationPlot.GraphPane.XAxis.Title.Text = xaxisTitle;
        }

        private void setPlotYAxisTitle(string yaxisTitle)
        {
            calibrationPlot.GraphPane.YAxis.Title.Text = yaxisTitle;
        }

        public string getFilename()
        {
            return filename;
        }

        public void setFilename(string filename) //to remove after deployment
        {
            this.filename = filename;
            this.textBoxFile.Text = filename;
        }

        private void setFilenameFromOpenFileDialog()
        {
            openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                textBoxFile.Text = filename;
            }
        }

        public void setCoefficientsType(Utilities.CoefficientsType type)
        {
            this.coefficientsType = type;
        }

        public void fillChamberDgv(IQueryable<Komora.Classes.DataBase.HardwareConfiguration> chambers)
        {
            dataGridViewChambers.DataSource = chambers;
        }

        public void fillPolynomialDgv<T>(IQueryable<T> polynomials)
        {
            dataGridViewPolynomial.DataSource = polynomials;
        }

        private bool onlyOneRowSelected(DataGridView dgv)
        {
            return (dgv.SelectedRows.Count == 1) ? true : false;
        }

        internal int getPolynomialOrderPt100()
        {
            return Int32.Parse(comboBoxPolyOrderLower.Text);
        }

        internal int getPolynomialOrderLower()
        {
            return Int32.Parse(comboBoxPolyOrderLower.Text);
        }

        internal int getPolynomialOrderHigher()
        {
            return Int32.Parse(comboBoxPolyOrderHigher.Text);
        }

        internal void showResults(string coefficientsString)
        {
            formatter = new Utilities.CoefficientsStringFormatter(coefficientsString);
            textBoxResultsLower.Text = formatter.formatString();
        }

        internal void showResults(string coefficientsStringLower, string coefficientsStringHigher)
        {
            formatter = new Utilities.CoefficientsStringFormatter(coefficientsStringLower);
            textBoxResultsLower.Text = formatter.formatString();

            formatter = new Utilities.CoefficientsStringFormatter(coefficientsStringHigher);
            textBoxResultsHigher.Text = formatter.formatString();
        }

        internal int getCurrentBound()
        {
            return Int32.Parse(textBoxCurrentBound.Text);
        }

        internal void drawMeasurementSamplesOnGraph(List<Tuple<double, double>> list, string lineName)
        {
            double[] x = list.Select( item => item.Item1).ToArray();
            double[] y = list.Select( item => item.Item2).ToArray();

            zedgraphController.DrawPoints(new ZedGraph.PointPairList(x, y), lineName);
        }

        private List<double> calculateApproximatedResults(double[] x_approximated, List<double> coefficients)
        {
            List<double> y_approximated = new List<double>();

            foreach (double x in x_approximated)
            {
                y_approximated.Add(Evaluate.Polynomial(x, coefficients.ToArray()));
            }

            return y_approximated;
        }

        private List<double> generateApproximatedVector(double x_min, double x_max, double approximationStep)
        {
            if (x_min >= x_max)
            {
                throw new Exception("x_min is greater or equal than x_max. Drawing approximated line failed.");
            }

            List<double> x_approximated = new List<double>();

            while (x_min <= x_max)
            {
                x_approximated.Add(x_min);
                x_min += approximationStep;
            }

            return x_approximated;
        }

        internal void clearGraph()
        {
            zedgraphController.ClearPlot();
        }

        internal void drawApproximationResultOnGraph(List<Tuple<double, double>> list, DataTypes.Pt100Polynomial pt100Polynomial, string lineName)
        {
            var coefficients = pt100Polynomial.getCoefficients();
            double x_min = list.Select(item => item.Item1).Min();
            double x_max = list.Select(item => item.Item1).Max();

            drawApproximateLine(x_min,x_max, coefficients, lineName);
        }

        internal void drawApproximationResultOnGraph(List<Tuple<double, double>> list, DataTypes.LedPolynomial ledPolynomial, string lineName)
        {
            double currentBound = Double.Parse(textBoxCurrentBound.Text);
            var coefficientsLowerCurrent = ledPolynomial.getLowerCurrentPolynomialCoefficients();
            var coefficientsHigherCurrent = ledPolynomial.getHigherCurrentPolynomialCoefficients(); 
            double x_min = list.Select(item => item.Item1).Min();
            double x_max = list.Select(item => item.Item1).Max();

            drawApproximateLine(x_min, currentBound, coefficientsLowerCurrent.getCoefficients(), lineName);
            drawApproximateLine(currentBound, x_max, coefficientsHigherCurrent.getCoefficients(), lineName);
        }

        private void drawApproximateLine(double x_min, double x_max, List<double> coefficients, string lineName)
        {
            double approximationStep = 0.1;
            double[] x_approximated = generateApproximatedVector(x_min, x_max, approximationStep).ToArray();
            double[] y_approximated = calculateApproximatedResults(x_approximated, coefficients).ToArray();
            zedgraphController.DrawLine(new ZedGraph.PointPairList(x_approximated, y_approximated), lineName);
        }
    }
}

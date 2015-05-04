using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Komora.Classes.Plot
{
    public class ZedGraphController
    {
        ZedGraphControl graph;
        GraphPane pane;
        LineItem temperature, temperatureDerivative, diodeCurrent;

        public ZedGraphController(ref ZedGraphControl zedGraph)
        {
            graph = zedGraph;
        }

        public void ClearPlot()
        {
            graph.GraphPane.CurveList.Clear();
            axisChangeZedGraph(graph);
        }

        public void DrawPoints(PointPairList points, string lineName)
        {
            LineItem curve = new LineItem(lineName);
            curve = graph.GraphPane.AddCurve(lineName, points, Color.Blue, SymbolType.Circle);
            curve.Line.IsVisible = false;
            axisChangeZedGraph(graph);
        }

        public void DrawLine(PointPairList points, string lineName)
        {
            LineItem curve = new LineItem(lineName);
            curve = graph.GraphPane.AddCurve(lineName, points, Color.Red, SymbolType.None);
            axisChangeZedGraph(graph);
        }

        delegate void axisChangeZedGraphCallBack(ZedGraphControl graph);
        private void axisChangeZedGraph(ZedGraphControl graph)
        {
            if (graph.InvokeRequired)
            {
                axisChangeZedGraphCallBack ad = new axisChangeZedGraphCallBack(axisChangeZedGraph);
                graph.Invoke(ad, new object[] { graph });
            }
            else
            {
                graph.AxisChange();
                graph.Invalidate();
                graph.Refresh();
            }
        }

        internal void configureMeasurementPlot()
        {
            pane = graph.GraphPane;
            pane.XAxis.Type = AxisType.Date;
            pane.XAxis.Scale.MajorUnit = DateUnit.Day;
            pane.XAxis.Scale.Format = "dd-MM-yyyy \n HH:mm:ss";
            pane.XAxis.Title.Text = "Date";

            pane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            pane.YAxis.Title.FontSpec.FontColor = Color.Red;
            pane.YAxis.Title.Text = "Temperature";

            YAxis yaxis = new YAxis();
            yaxis.Scale.FontSpec.FontColor = Color.Blue;
            yaxis.Title.FontSpec.FontColor = Color.Blue;
            yaxis.Title.Text = "Temperature derivative";
            pane.YAxisList.Add(yaxis);

            pane.Y2Axis.Scale.FontSpec.FontColor = Color.Green;
            pane.Y2Axis.Title.FontSpec.FontColor = Color.Green;
            pane.Y2Axis.Title.Text = "Diode current";
            pane.Y2Axis.IsVisible = true;

            axisChangeZedGraph(graph);
        }

        internal void DrawLines(PointPairList temperaturePoints, PointPairList temperatureDerivativePoints, PointPairList diodeCurrentPoints)
        {
            pane = graph.GraphPane;

            temperature = pane.AddCurve("Temperature", temperaturePoints, Color.Red);
            temperature.IsX2Axis = false;
            temperature.YAxisIndex = 0;

            temperatureDerivative = pane.AddCurve("Temperature derivative", temperatureDerivativePoints, Color.Blue);
            temperatureDerivative.IsY2Axis = false;
            temperatureDerivative.YAxisIndex = 1;

            diodeCurrent = pane.AddCurve("Diode current", diodeCurrentPoints, Color.Green);
            diodeCurrent.IsY2Axis = true;

            RefreshPlot();
        }

        internal void RefreshPlot()
        {
            axisChangeZedGraph(graph);
        }
    }
}

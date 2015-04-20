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
    }
}

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
        public void ClearPlot(ref ZedGraphControl zg)
        {
            zg.GraphPane.CurveList.Clear();
            axisChangeZedGraph(zg);
        }

        public void DrawPoints(ref ZedGraphControl zg, PointPairList points, string lineName)
        {
            LineItem curve = new LineItem(lineName);
            curve = zg.GraphPane.AddCurve(lineName, points, Color.Blue, SymbolType.Circle);
            curve.Line.IsVisible = false;
            axisChangeZedGraph(zg);
        }

        public void DrawLine(ref ZedGraphControl zg, PointPairList points, string lineName)
        {
            LineItem curve = new LineItem(lineName);
            curve = zg.GraphPane.AddCurve(lineName, points, Color.Red, SymbolType.None);
            axisChangeZedGraph(zg);
        }

        delegate void axisChangeZedGraphCallBack(ZedGraphControl zg);
        private void axisChangeZedGraph(ZedGraphControl zg)
        {
            if (zg.InvokeRequired)
            {
                axisChangeZedGraphCallBack ad = new axisChangeZedGraphCallBack(axisChangeZedGraph);
                zg.Invoke(ad, new object[] { zg });
            }
            else
            {
                zg.AxisChange();
                zg.Invalidate();
                zg.Refresh();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.Algorithm
{
    public static class DerivativeCalculator
    {
        public static ZedGraph.PointPairList calculate(ZedGraph.PointPairList sourcePoints)
        {
            ZedGraph.PointPairList derivative = new ZedGraph.PointPairList();

            if (sourcePoints.Count < 2)
            {
                return derivative;
            }

            List<double> X = sourcePoints.Select(c => c.X).ToList();
            List<double> Y = sourcePoints.Select(c => c.Y).ToList();
            double h;
            double derivativeValue;

            for (int i = 0; i < sourcePoints.Count-1; ++i)
            {
                h = X[i+1] - X[i];
                derivativeValue = (Y[i+1] - Y[i]) / (2 * h);

                derivative.Add(X[i+1], derivativeValue);
            }

            return derivative;
        }
    }
}

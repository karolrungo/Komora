using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.DataTypes
{
    public class MeasurementSamples<T>
    {
        public List<Tuple<T, T>> samples;

        public MeasurementSamples()
        {
            samples = new List<Tuple<T, T>>();
        }

        public MeasurementSamples(MeasurementSamples<T> measurementSamples)
        {
            this.samples = measurementSamples.samples;
        }

        public MeasurementSamples(List<T> x, List<T> y): this()
        {
            for (int i = 0; i < x.Count; ++i)
            {
                samples.Add(new Tuple<T, T>(x[i], y[i]));
            }
        }

        public MeasurementSamples(List<Tuple<T, T>> list)
        {
            this.samples = list;
        }

    }
}

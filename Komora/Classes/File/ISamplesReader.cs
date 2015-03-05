using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komora.Classes.File
{
    public interface ISamplesReader<T>
    {
        Komora.DataTypes.MeasurementSamples<T> readSamplesFromFile(string filename);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komora.DataTypes;

namespace Komora.Classes.File.Csv
{
    public class CsvReader<T> : IFileReader
    {

        public string[] getFileContent(string filename)
        {
            //gdzie lapac wyjatek?
            return  System.IO.File.ReadAllLines(filename);
        }

        public MeasurementSamples<T> readSamplesFromFile(string filename) 
        {
            return convertFileContentToMeasurementSamples(getFileContent(filename));
        }

        private MeasurementSamples<T> convertFileContentToMeasurementSamples(string[] fileContent)
        {
            MeasurementSamples<T> samples = new MeasurementSamples<T>();
           
            //tu skonczylem ;)
            return new MeasurementSamples<T>(); 
        }
    }
}

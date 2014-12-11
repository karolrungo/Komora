using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komora.DataTypes;
using System.Threading;

namespace Komora.Classes.File
{
    public class MeasurementSamplesReader<T>
    {
        List<T> x, y;

        public MeasurementSamplesReader()
        {
            x = new List<T>();
            y = new List<T>();
        }

        private string[] getFileContent(string filename)
        {
            //wyjatek
                return System.IO.File.ReadAllLines(filename);
        }

        public MeasurementSamples<T> readSamplesFromFile(string filename) 
        {
            return convertFileContentToMeasurementSamples(getFileContent(filename));
        }

        private MeasurementSamples<T> convertFileContentToMeasurementSamples(string[] fileContent)
        {
            foreach (string row in fileContent)
            {
                string[] rowElements = row.Split(',');
                checkIfRowHasWrongSize(rowElements);
                addRowToSamplesList(rowElements);
            }
            return new MeasurementSamples<T>(x, y);
        }

        private void checkIfRowHasWrongSize(string[] rowElements)
        {
            if (rowElements.Length != 2)
                throw new FormatException("At least one column size in csv file is not 2");
        }

        private void addRowToSamplesList(string[] rowElements)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
            var converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));
            x.Add((T)converter.ConvertFromString(rowElements[0])); 
            y.Add((T)converter.ConvertFromString(rowElements[1]));
        }
    }
}

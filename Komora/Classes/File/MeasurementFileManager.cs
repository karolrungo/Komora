using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komora.Classes.File
{
    public class MeasurementFileManager
    {
        private string filePath;
        private const char separator = ':';
        private DataTypes.ControllerValues controllerValues;
        private FileStream filestream;
        private StreamWriter streamWriter;

        private readonly int errorColumn = 4;
        private readonly int dateColumn = 5;

        public MeasurementFileManager(string filePath/*, ref DataTypes.ControllerValues controllerValues*/)
        {
            this.filePath = filePath;
            //this.controllerValues = controllerValues;
        }

        public MeasurementFileManager()
        {}

        public void deleteFile()
        {
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }

        public void writeDataToFile(int segmentNumber, Segment.SEGMENT_TYPE sEGMENT_TYPE, string pv, string sp, string err, string date)
        {
            openFile();
            streamWriter.WriteLine(buildFileRow(segmentNumber, sEGMENT_TYPE, pv, sp, err, date));
            closeFile();
        }

        public void createFileIfNotExists()
        {
            if (!System.IO.File.Exists(filePath))
            {
                if (!Directory.Exists(filePath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }
                System.IO.File.Create(filePath);
            }
        }

        private void openFile()
        {
            filestream = System.IO.File.Open(filePath, FileMode.Append, FileAccess.Write, FileShare.None);
            streamWriter = new StreamWriter(filestream);
        }

        private void closeFile()
        {
            streamWriter.Close();
            filestream.Close();
        }

        private string getSegmentTypeString(Segment.SEGMENT_TYPE sEGMENT_TYPE)
        {
            string segmentType = "";

            switch (sEGMENT_TYPE)
            {
                case Segment.SEGMENT_TYPE.dynamic:
                    segmentType = "dynamic";
                    break;
                case Segment.SEGMENT_TYPE.final:
                    segmentType = "final";
                    break;
                case Segment.SEGMENT_TYPE.start:
                    segmentType = "start";
                    break;
                case Segment.SEGMENT_TYPE.izothermal:
                    segmentType = "izothermal";
                    break;
                default:
                    return "";
            }
            return segmentType;
        }

        private string buildFileRow(int segmentNumber, Segment.SEGMENT_TYPE sEGMENT_TYPE, string pv, string sp, string err, string date)
        {
            StringBuilder row = new StringBuilder();
            row.Append(segmentNumber.ToString()).Append(separator);
            row.Append(getSegmentTypeString(sEGMENT_TYPE)).Append(separator);
            row.Append(sp).Append(separator);
            row.Append(pv).Append(separator);
            row.Append(err).Append(separator);
            row.Append(date);
            return row.ToString();
        }

        internal List<double> getErrorValuesFromFile(string filename)
        {
            List<double> values = new List<double>();
            string[] content = System.IO.File.ReadAllLines(filename);

            foreach (string row in content)
            {
                string[] rowElements = row.Split(separator);
                values.Add(Double.Parse(rowElements[errorColumn]));
            }

            return values;
        }

        internal List<double> getTimeDeltaFromFile(string filename)
        {
            List<double> values = new List<double>();
            List<DateTime> dates = new List<DateTime>();
            string[] content = System.IO.File.ReadAllLines(filename);

            foreach (string row in content)
            {
                string[] rowElements = row.Split(separator);

                dates.Add(DateTime.ParseExact(rowElements[dateColumn],
                                              "dd-M-yyyy HH-mm-ss",
                                              System.Globalization.CultureInfo.InvariantCulture));
            }

            values.Add(0);
            for (int i = 1; i < dates.Count; ++i)
            {
                values.Add((dates.ElementAt(i) - dates.ElementAt(0)).TotalSeconds);
            } 

            return values;
        }
    }
}

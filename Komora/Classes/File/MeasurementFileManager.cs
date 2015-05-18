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
        private StreamReader streamReader;

        public MeasurementFileManager(string filePath, ref DataTypes.ControllerValues controllerValues)
        {
            this.filePath = filePath;
            this.controllerValues = controllerValues;
        }

        public void deleteFile()
        {
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            else
            {
                //throw new FileNotFoundException("File not found!"); 
            }
        }

        public void writeDataToFile(int segmentNumber, Segment.SEGMENT_TYPE sEGMENT_TYPE)
        {
            openFile();
            streamWriter.WriteLine(buildFileRow(segmentNumber, sEGMENT_TYPE));
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

        private string buildFileRow(int segmentNumber, Segment.SEGMENT_TYPE sEGMENT_TYPE)
        {
            StringBuilder row = new StringBuilder();
            row.Append(segmentNumber.ToString()).Append(separator);
            row.Append(getSegmentTypeString(sEGMENT_TYPE)).Append(separator);
            row.Append(controllerValues.heater_Params.sp.ToString()).Append(separator);
            row.Append(controllerValues.heater_Params.pv.ToString()).Append(separator);
            row.Append(controllerValues.heater_Params.cv.ToString()).Append(separator);
            row.Append(controllerValues.heater_Params.err.ToString()).Append(separator);
            row.Append(String.Format("{0:d/M/yyyy HH:mm:ss}", controllerValues.heater_Params.dateTime));
            return row.ToString();
        }
    }
}

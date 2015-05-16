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

        public void writeDataToFile()
        {
            openFile();

            //Byte[] info = new UTF8Encoding(true).GetBytes(DateTime.Now.ToLongDateString() + Environment.NewLine);
            // Add some information to the file.
            streamWriter.WriteLine(DateTime.Now.ToLongTimeString());
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
    }
}

using System;
using System.IO;
using System.Text;

namespace PingMetrics
{
    public class PingLog
    {
        private string _directory;
        private string _logFilePath;
        public string Name { get;}

        public PingLog(string fileDirectory, string logName)
        {
            _directory = fileDirectory;
            Name = logName;
            if (!Name.EndsWith(".log"))
            {
                Name += ".log";
            }
            bool pathExists = Directory.Exists(_directory);
            if (!pathExists)
            {
                Directory.CreateDirectory(_directory);
            }
            _logFilePath = Path.Combine(_directory, Name).ToString();
            File.CreateText(_logFilePath).Close();
        }
        public void WriteLineToLog(string stringToWrite)
        {
            try
            {
                File.AppendAllText(_logFilePath, stringToWrite + "\n");
            } catch (IOException e) { 
                    throw e;
            }
        }
        public string ReadFromLog(StreamReader logReader)
        {
            string output = "";
            string line;
            while ((line = logReader.ReadLine()) != null)
            {
                output += line;
            }
            return output;
        }
    }
}

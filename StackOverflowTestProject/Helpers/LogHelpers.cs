using StackOverflowAutoFramework.Config;
using System;
using System.IO;


namespace StackOverflowAutoFramework.Helpers
{
   public class LogHelpers
    {

        // Global declaration of the log file name to make it unique 

        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamWriter = null;
        /// <summary>
        /// File which can store the log information
        /// </summary>
        public static void CreateLogFile()
        {
            string directory = Settings.logPath;
            if (Directory.Exists(directory))
            {
                _streamWriter = File.AppendText(directory + _logFileName + ".log");

            }
            else
            {
                Directory.CreateDirectory(directory);
                _streamWriter = File.AppendText(directory + _logFileName +".log");

            }
        }
        /// <summary>
        /// Method which can write the text in the log file
        /// </summary>
        /// <param name="logMessage"></param>
        public static void WriteLog(string logMessage)
        {
            _streamWriter.Write("{0}  {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamWriter.WriteLine("     {0}", logMessage);
            _streamWriter.Flush();

        }
       
    }
}

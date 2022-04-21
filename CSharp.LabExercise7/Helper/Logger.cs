using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp.LabExercise7.Service
{
    class Logger
    {
        private static Logger INSTANCE;

        private void Log(string logMessage, TextWriter tw)
        {
            tw.Write("\nLog Entry: ");
            tw.WriteLine($"{DateTime.Now.ToLongDateString()}");
            tw.WriteLine($"Accessed by: PC {Environment.UserName} on {logMessage}");
            tw.WriteLine("-------------------------------------------");
        }

        public static Logger GetInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Logger();
            }
            return INSTANCE;
        }

        //create log file
        public void AddToLog()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\application." + DateTime.Now.ToString("MMddyyyy") + ".log";

            if (File.Exists(filePath))
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    Log($"{DateTime.Now.ToString("h:mm:ss tt")}", sw);
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    Log($"{DateTime.Now.ToString("h:mm:ss tt")}", sw);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CalculatorApp.Class
{
    public class Log 
    {
        public static void WriteLog(string logMessage)
        {
            string filePath = Environment.CurrentDirectory;
            string fileName = "History.txt";
            string fullPath = Path.Combine(filePath, fileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    sw.WriteLine($"{DateTime.UtcNow} {logMessage}");
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

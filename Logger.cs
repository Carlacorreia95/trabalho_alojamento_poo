using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trabalho_Alojamento_POO
{
    public static class Logger

    {
        private static readonly string logFilePath = "ApplicationLogs.txt";

        public static void Log_error(string message, Exception ex)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] ERROR: {message}");
                    writer.WriteLine($"Exception: {ex.Message}");
                    writer.WriteLine($"StackTrace: {ex.StackTrace}");
                    writer.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Logger failed");
            }
        }
    }
}

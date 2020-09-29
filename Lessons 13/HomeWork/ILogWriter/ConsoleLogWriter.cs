using System;
using System.Collections.Generic;
using System.Text;

namespace ILogWriter
{
    class ConsoleLogWriter : ILogWriter
    {
        public string message;
        DateTime localDate = DateTime.Now;

        public void LogInfo(string message)
        {
            Console.WriteLine($"{localDate.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Info,\t {message}");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"{localDate.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Warning,\t {message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{localDate.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Error,\t {message}");
        }
    }
}

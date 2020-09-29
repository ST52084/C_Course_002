using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ILogWriter
{
    class FileLogWriter : ILogWriter
    {
        public string message;
        DateTime localDate = DateTime.Now;
        public void LogInfo(string message)
        {
            File.AppendAllText("log.txt", $"\n {localDate.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Info,\t {message}");
        }
        public void LogWarning(string message)
        {
            File.AppendAllText("log.txt", $"\n {localDate.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Warning,\t {message}");
        }
        public void LogError(string message)
        {
            File.AppendAllText("log.txt", $"\n {localDate.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Error,\t {message}");
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ILogWriter
{
    class FileLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            File.AppendAllText("log.txt", $"\n {DateTimeOffset.UtcNow.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Info,\t {message}");
        }
        public void LogWarning(string message)
        {
            File.AppendAllText("log.txt", $"\n {DateTimeOffset.UtcNow.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Warning,\t {message}");
        }
        public void LogError(string message)
        {
            File.AppendAllText("log.txt", $"\n {DateTimeOffset.UtcNow.ToString("yyyy - MM - ddThh:mm: ss.fffzzz")},\t Error,\t {message}");
        }
    }
}

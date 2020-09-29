using System;
using System.Collections.Generic;
using System.Text;

namespace ILogWriter
{
    interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string massage);
    }
}

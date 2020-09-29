using System;
using System.Collections.Generic;
using System.Text;

namespace ILogWriter
{
    class MultipleLogWriter : FileLogWriter          //ConsoleLogWriter //FileLogWriter
    {
        public MultipleLogWriter(List<ILogWriter> CollekciaClassov, string message)
        {
            foreach (var item in CollekciaClassov)
            {
                item.LogInfo(message);
                item.LogWarning(message);
                item.LogError(message);
            }
        }
    }
}

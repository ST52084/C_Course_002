using System;
using System.Collections.Generic;
using System.Text;

namespace ILogWriter
{
    class MultipleLogWriter : ILogWriter
    {
        List<ILogWriter> collekciaClassov;
        public MultipleLogWriter(List<ILogWriter> CollekciaClassov)
        {
            collekciaClassov = CollekciaClassov;
        }

        public void LogError(string massage)
        {
            foreach (var item in collekciaClassov)
            {
                item.LogError(massage);
            }
        }

        public void LogInfo(string message)
        {
            foreach (var item in collekciaClassov)
            {
                item.LogInfo(message);
            }
        }

        public void LogWarning(string message)
        {
            foreach (var item in collekciaClassov)
            {
                item.LogWarning(message);
            }
        }
    }
}

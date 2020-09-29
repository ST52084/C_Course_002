using System;
using System.Collections.Generic;

namespace ILogWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILogWriter> CollekciaClassov = new List<ILogWriter>();
            FileLogWriter a = new FileLogWriter();
            ConsoleLogWriter b = new ConsoleLogWriter();
            CollekciaClassov.Add(a);
            CollekciaClassov.Add(b);
            MultipleLogWriter c = new MultipleLogWriter(CollekciaClassov, "Любое сообщение");
        }
    }
}

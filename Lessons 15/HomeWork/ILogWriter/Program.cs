using System;
using System.Collections.Generic;

namespace ILogWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string massage = "Сообщение";
            List<ILogWriter> CollekciaClassov = new List<ILogWriter>();
            FileLogWriter a = new FileLogWriter();
            ConsoleLogWriter b = new ConsoleLogWriter();
            CollekciaClassov.Add(a);
            CollekciaClassov.Add(b);
            MultipleLogWriter c = new MultipleLogWriter(CollekciaClassov);
            c.LogError(massage);
            c.LogInfo(massage);
            c.LogInfo(massage);

            ////////////////////////////////

            var p1 = LogWriterFactory.Instance;
            var p2 = LogWriterFactory.Instance;
            
            p1.GetLogWriter();

            LogWriterFactory F = LogWriterFactory.Instance;
            //F.GetLogWriter(CollekciaClassov);



        }
    }
}

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
            //c.LogError(massage);
            //c.LogInfo(massage);
            //c.LogInfo(massage);

            ////////////////////////////////


            LogWriterFactory<ILogWriter> F = LogWriterFactory<ILogWriter>.Instance;
            F.GetLogWriter<ILogWriter>(c).LogError(massage);
            F.GetLogWriter<ILogWriter>(c).LogInfo(massage);
            F.GetLogWriter<ILogWriter>(c).LogWarning(massage);


        }
    }
}

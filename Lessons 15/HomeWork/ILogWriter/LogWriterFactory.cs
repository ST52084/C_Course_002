using System;
using System.Collections.Generic;
using System.Text;

namespace ILogWriter
{

    class LogWriterFactory<T>
    {

        
        private static LogWriterFactory<T> instace;


        public static LogWriterFactory<T> Instance =>
            instace ?? (instace = new LogWriterFactory<T>());

        private LogWriterFactory()
        {
        }
        

        public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
        {
            return (ILogWriter)parameters;
        }
    }
}

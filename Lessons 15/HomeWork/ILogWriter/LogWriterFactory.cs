using System;
using System.Collections.Generic;
using System.Text;

namespace ILogWriter
{

    class LogWriterFactory 
    {
        //private LogWriterFactory _nameClass;
        private static LogWriterFactory instace;


        public static LogWriterFactory Instance =>
            instace ?? (instace = new LogWriterFactory());

        private LogWriterFactory()
        {
        }


        public ILogWriter GetLogWriter<T>(object parameters) where T : ILogWriter
        {
            //return (ILogWriter)instace;
            return (ILogWriter)parameters;
            //return (ILogWriter)_logWriterFactory;
        }

    }
}

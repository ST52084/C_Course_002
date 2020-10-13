using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] data = new Byte[4] { 1, 2, 3, 5 };

            var writer = new FileWriterWithProgress();
            writer.WriteBytes("log.txt", data, Convert.ToSingle(0.15));
        }
    }
}

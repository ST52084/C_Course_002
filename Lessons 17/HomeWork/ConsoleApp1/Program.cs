using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Byte[] data = new Byte[100];

            for (int i = 0; i < 100; i++)
            {
                data[i] = Convert.ToByte(i);
            }

            var writer = new FileWriterWithProgress();
            writer.WritingPerformed += Writer_WritingPerformed;
            writer.WritingCompleted += Writer_WritingCompleted1;

            writer.WriteBytes("log.txt", data, Convert.ToSingle(0.10));
        }

        private static void Writer_WritingPerformed(object sender, GeneratorEventArgs e)
        {
            Console.WriteLine("Событие - WritingPerformed");
        }

        private static void Writer_WritingCompleted1(object sender, EventArgs e)
        {
            Console.WriteLine("Событие - WritingCompleted");
        }


    }
}

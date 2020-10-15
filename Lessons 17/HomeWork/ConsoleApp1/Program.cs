using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] data = new Byte[4] { 1, 2, 3, 5 };

            var writer = new FileWriterWithProgress();
            writer.WritingCompleted += Writer_WritingCompleted;
            writer.WritingPerformed += Writer_WritingPerformed;

            writer.WriteBytes("log.txt", data, Convert.ToSingle(0.15));
        }


        private static void Writer_WritingCompleted(object sender, GeneratorEventArgs e)
        {
            Console.WriteLine("Событие - WritingCompleted");
        }
        private static void Writer_WritingPerformed(object sender, GeneratorEventArgs e)
        {
            Console.WriteLine("Событие - WritingPerformed");
            File.WriteAllBytes("txt.txt", e.MassByte);
        }

    }
}

using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Generator();
            a1.DataGenerator += A1_DataGenerator; // подписываемся на событие
            a1.Generate(10);
        }

        private static void A1_DataGenerator(byte[] obj)
        {
            File.WriteAllBytes("txt.txt", obj);
        }
    }
}

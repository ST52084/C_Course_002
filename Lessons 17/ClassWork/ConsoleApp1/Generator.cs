using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Generator
    {
        public event Action<byte[]> DataGenerator; // создаем событие
        public void Generate(int count)
        {
            byte[] a = new byte[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                a[i] = Convert.ToByte(rand.Next(0, 100));
            }
            DataGenerator?.Invoke(a);   // проверяем на нуль
        }
        // ctor - горячие клавиши для создания конструктора
    }
}

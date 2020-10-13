using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FileWriterWithProgress
    {
        public event Action WritingPerformed;
        public event Action WritingCompleted;

        public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {
            for (int i = 0; i < (Math.Truncate(1 / percentageToFireEvent)); i++)
            {
                WritingPerformed += A1_WritingPerformed;

            }
            WritingCompleted += A1_WritingCompleted;

            WritingPerformed?.Invoke();
            WritingCompleted?.Invoke();
        }

        private void A1_WritingCompleted()
        {
            Console.WriteLine("Событие - WritingCompleted");
        }

        private void A1_WritingPerformed()
        {
            Console.WriteLine("Событие - WritingPerformed");
        }
    }

}

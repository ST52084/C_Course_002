using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FileWriterWithProgress
    {
        public event EventHandler<GeneratorEventArgs> WritingPerformed;
        public event EventHandler<GeneratorEventArgs> WritingCompleted;
        

        public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {

            var b = new GeneratorEventArgs();
            b.MassByte = data;

            for (int i = 0; i < (Math.Truncate(1 / percentageToFireEvent)); i++)
            {
                WritingPerformed?.Invoke(this, b);
            }
            WritingCompleted?.Invoke(this, b);
        }
    }

    class GeneratorEventArgs
    {
        public byte[] MassByte { get; set; }
    }

}

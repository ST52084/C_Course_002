using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class FileWriterWithProgress
    {
        public event EventHandler<GeneratorEventArgs> WritingPerformed;
        public event EventHandler WritingCompleted;
        
        public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {

            var b = new GeneratorEventArgs();
            b.MassByte = data;
            b.percentage = 0;



            for (int i = 0; i < (Math.Truncate(1 / percentageToFireEvent)); i++)
            {

                //foreach (var item in b.MassByte)
                //{
                //    File.AppendAllText("txt.txt", item.ToString());
                //}

                //File.AppendAllText("txt.txt", b.MassByte.Select(i => i.ToString()).ToArray());
                WritingPerformed?.Invoke(this, b);

            }
            WritingCompleted?.Invoke(this, b);
        }
    }

    class GeneratorEventArgs : EventArgs
    {
        public byte[] MassByte { get; set; }
        public float percentage {get; set;}
    }
    
}

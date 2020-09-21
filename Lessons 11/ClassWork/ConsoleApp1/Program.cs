using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var cat = new Pet ("Tom", DateTimeOffset.Parse("01.01.2018"));
            //cat.Name = "Tom";        
            cat.Sex = 'M';
            cat.Kind = "Cat";
            //cat.Date = DateTimeOffset.Parse("01.01.2018");
            cat.Age();

            cat.WriteProperties(showFullDescription: true);
            cat.WriteProperties();
        }
    }
}

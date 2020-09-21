using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    partial class Pet
    {
        public string Description =>
           $"Name: {Name}, Age: {Age()}, Sex: {Sex}, Kind: {Kind}";

        public string ShortDescription =>
            $"Name: {Name}, Age: {Age()}";

        public void WriteProperties(bool showFullDescription = false)
        {
            if (showFullDescription)
            {
                Console.WriteLine(Description);
            }
            else
            {

                Console.WriteLine(ShortDescription);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    partial class Pet
    {
        public string Kind;
        public string Name;
        public char Sex;
        public DateTimeOffset Date;

        public Pet(string name, DateTimeOffset date)   ///Конструктор
        {
            Name = name;
            Date = date; 
        }

        public int Age()
        {
            return (int)((DateTimeOffset.Now - Date).TotalDays / ((365 * 4 + 366) / 5.0));
        }

        //public string Description =>
        //    $"Name: {Name}, Age: {Age()}, Sex: {Sex}, Kind: {Kind}";

        //public string ShortDescription =>
        //    $"Name: {Name}, Age: {Age()}";

        public void UpdateProperties(string name, DateTimeOffset age)
        {
            Name = name;
            Date = age;
        }

        public void UpdateProperties(string name, char sex)
        {
            Name = name;
            Sex = sex;
        }

        //public void WriteProperties(bool showFullDescription = false)
        //{
        //    if (showFullDescription)
        //    {
        //        Console.WriteLine(Description);
        //    }
        //    else
        //    {

        //        Console.WriteLine(ShortDescription);
        //    }
        //}

    }
}

using System;

namespace Class_people
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            
            People[] people = new People[3];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new People();
                Console.Write($"Enter name {i}:");
                people[i].Name = Console.ReadLine();

                Console.Write($"Enter age {i}:");
                people[i].Age = Console.ReadLine();
            }

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].Description);
            }
            Console.ReadKey();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

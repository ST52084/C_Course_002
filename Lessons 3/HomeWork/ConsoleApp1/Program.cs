using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] names = new string[3];
            int [] age = new int[3];

        
            for (int i = 0; i< names.Length; i++)
			{

            Console.WriteLine("Введите имя человека:");
                names[i] = Console.ReadLine();

            Console.WriteLine("Введите возраст человек:");
                age[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("--------------------------");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Имя: "+names[i]+ ",\t возраст через 4 года: " + "\t"+ + (age[i]+4));
            }
            Console.ReadKey();
        }
    }
}

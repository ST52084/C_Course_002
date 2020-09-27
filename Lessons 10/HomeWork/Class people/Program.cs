using System;

namespace Class_people
{
    class Program
    {
        static void Main(string[] args)
        {
            People[] people = new People[3];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new People();
                people[i].Name = ReadStringWithoutExceptionName($"Enter name {i}:");
                people[i].Age = ReadStringWithoutExceptionAge($"Enter age {i}:");
            }

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].Description + people[i].AgeAfter_4_Years);
            }
            Console.ReadKey();


        }

        static string ReadStringWithoutExceptionName(string caption)
        {
            for (; ; )
            {
                Console.WriteLine(caption);
                string value = Console.ReadLine();
                if (string.IsNullOrEmpty(value.ToString()) == true)
                {
                    Console.WriteLine("Имя не должно быть пустым.");
                }

                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        Console.WriteLine("В имени должны быть только печатные символы.");
                        break;
                    }
                    else
                    {
                        return value;
                    }
                }
            }
        }

        static string ReadStringWithoutExceptionAge(string caption)
        {
            int age;
            for (; ; )
            {
                Console.WriteLine(caption);
                string value = Console.ReadLine();
                if (int.TryParse(value, out age))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть целым числом.");
                }
            }
        }
    }
}

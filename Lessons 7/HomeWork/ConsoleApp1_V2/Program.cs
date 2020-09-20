using System;

namespace ConsoleApp1_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayWord = new string[] { };
            int cWord = 0;

            Console.WriteLine("Введите строку из нескольких слов:");

            do
            {
                arrayWord = ReadWord();
                foreach (var item in arrayWord)
                {

                    if (item.LastIndexOf("А") == 0)
                    {
                        cWord++;
                    }
                }

            } while (arrayWord.Length == 0);
            Console.WriteLine("Количество слов, начинающихся с буквы 'А': " + cWord);
        }
        static string[] ReadWord()
        {
            string ReadWord = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(ReadWord))
            {
                Console.WriteLine("Строчка не должна быть пустой.");
                return new string[] { };
            }
            string[] arrayWord = ReadWord.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);   /// делим строку на массив по заданному символу
            if (arrayWord.Length >= 2)
            {
                return arrayWord;
            }
            else
            {
                Console.WriteLine("Слишком мало слов: (Попробуйте ещё раз: ");
                return new string[] { };
            }
        }
    }
}

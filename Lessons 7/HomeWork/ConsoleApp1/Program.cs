using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayWord = ReadWord("Введите строку из нескольких слов:");
            int cWord = 0;

            while (arrayWord[0] == null)
            {
                arrayWord = ReadWord("Слишком мало слов :( Попробуйте ещё раз:");
            }


            for (int i = 0; i < arrayWord.Length; i++)
            {
                if (arrayWord[i].LastIndexOf("А") == 0)
                {
                    cWord++;
                }
            }

            Console.WriteLine("Количество слов, начинающихся с буквы 'А': " + cWord);
        }


        static string[] ReadWord(string text)

        {
            Console.WriteLine(text);
            string ReadWord = Console.ReadLine();

            string[] arrayWord = ReadWord.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);   /// делим строку на массив по заданному символу

            if (arrayWord.Length >= 2)
            
            {
                return arrayWord;
            }
            else
            {
                return new string[] { null };
            }
            
        }

    }
}

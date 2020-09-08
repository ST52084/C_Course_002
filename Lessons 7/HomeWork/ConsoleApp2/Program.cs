using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strWord = ReadWord("Введите непустую строку:");

            while (strWord == null)
            {
                strWord = ReadWord("Попробуйте ещё раз:");
            }

            strWord = strWord.ToLower();

            char[] arr = strWord.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }

        static string ReadWord(string text)

        {
            Console.WriteLine(text);
            string readWord = Console.ReadLine();
            string[] nePecatSimbol = { "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "=" }; /// не печатные символы ?

            for (int i = 0; i < readWord.Length; i++)
            {
                for (int j = 0; j < nePecatSimbol.Length; j++)
                {

                    if (readWord[i].ToString() == nePecatSimbol[j].ToString())
                    {
                        Console.WriteLine("Вводите только печатные симвыолы :(");
                        return null;
                    }
                }
            }

            if (readWord == "")
            {
                Console.WriteLine("Вы ввели пустую строку :(");
                return null;
            }

            else
            {
                return readWord;
            }
        }
    }
}

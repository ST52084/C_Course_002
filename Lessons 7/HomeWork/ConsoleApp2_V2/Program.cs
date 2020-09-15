using System;


namespace ConsoleApp2_V2
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
            string readWord = Console.ReadLine().ToLower();
            char[] array = new char[readWord.Length];
            char[] separators = { ',', '.', ' ' };
            for (int i = 0; i < readWord.Length; i++)
            {
                array[i] = readWord[i];
                if (!char.IsLetter(array[i]))
                {
                    if (Array.IndexOf(separators, array[i]) == -1 & false == String.IsNullOrWhiteSpace(readWord))
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

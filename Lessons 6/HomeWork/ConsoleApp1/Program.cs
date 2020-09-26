using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное натуральное число не более 2 миллиардов:");
            int natNumber = ReadNumberWithoutException();
            string number = natNumber.ToString();
            int j = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (Convert.ToUInt32(number[i]) % 2 == 0 && number[i] != '0')
                    j++;
            }
            Console.WriteLine("В числе " + number + " содержится следующее количество четных цифр: " + j);
        }

        static int ReadNumberWithoutException()
        {
            for (; ; )
            {
                int Number;
                try
                {
                    Number = Convert.ToInt32(Console.ReadLine());

                    if (Number > 0 && Number <= 2_000_000_000)
                    {
                        return Number;
                    }

                    else
                    {
                        Console.WriteLine("Введено неверное значение! Попробуйте ещё раз:");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка System.OverflowException! Попробуйте ещё раз:");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Ошибка System.FormatException! Попробуйте ещё раз:");
                }
            }
        }

    }
}

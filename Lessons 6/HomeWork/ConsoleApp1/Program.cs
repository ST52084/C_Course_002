using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное натуральное число не более 2 миллиардов:");
            int natNumber = ReadNumberWithoutException();
            int number = natNumber;
            int j = 0;
            do
            {

                if (natNumber % 2 == 0)
                    j++;
                natNumber = natNumber - 1;
            } while (natNumber != 0);

            Console.WriteLine("В числе " + number + " содержится следующее количество четных цифр: " + j);

        }

        static int ReadNumberWithoutException()
        {
            for (; ; )
            {
                ///Console.WriteLine(caption);
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

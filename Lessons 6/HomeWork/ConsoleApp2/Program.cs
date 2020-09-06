using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstVznos = ReadNumberWithoutException("Введите сумму первоначального взноса в рублях:");
            decimal everyDayPay = ReadNumberWithoutException("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0,01)");
            decimal sumRequired = ReadNumberWithoutException("Введите желаемую сумму накопления в рублях:");


            if (firstVznos == 0)
                Console.WriteLine("Так ничего не получится");
            else if (everyDayPay == 0)
                Console.WriteLine("Так ничего не получится");
            else if (sumRequired == 0)
                Console.WriteLine("Так ничего не получится");
            else
            {


                int daysRequired = 0;  /// Число требуемых дней до накопления

                do
                {
                    firstVznos = firstVznos + firstVznos * everyDayPay;
                    daysRequired++;
                } while (firstVznos < sumRequired);


                Console.WriteLine("Необходимое количество дней для накопления желаемой суммы: " + daysRequired);
            }
        }

        static decimal ReadNumberWithoutException(string text)
        {
            Console.WriteLine(text);
            decimal number = 0;
            try
            {
                var vvod = Console.ReadLine().Replace('.', ',');
                number = Convert.ToDecimal(vvod);
                return number;
            }

            catch (System.FormatException)
            {
                return 0;
            }
        }
    }
}

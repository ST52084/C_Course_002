using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число");
            Double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите 2 число");
            Double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сумма чисел:{0} \t Разница чисел:{1} \t Произведение чисел:{2}", (firstNumber + secondNumber), (firstNumber - secondNumber), (firstNumber * secondNumber));

        }
    }
}

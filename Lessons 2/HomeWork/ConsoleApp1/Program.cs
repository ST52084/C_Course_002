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

            Console.WriteLine("Какую операция выполняем, введите символ");
            Console.WriteLine("С - Сложение");
            Console.WriteLine("В - Вычитание");
            Console.WriteLine("У - множение");
            Console.WriteLine("Д - деление");
            Console.WriteLine("О - остаток от деления");
            Console.WriteLine("Т - возведение в степень");
            string arithmeticOperation = Console.ReadLine().ToUpper();


            double resultat = 0;
            if (arithmeticOperation == "С")      { Console.WriteLine("Результат вычисления: " + (resultat = firstNumber + secondNumber)); }
            else if (arithmeticOperation == "В") { Console.WriteLine("Результат вычисления: " + (resultat = firstNumber - secondNumber)); }
            else if (arithmeticOperation == "У") { Console.WriteLine("Результат вычисления: " + (resultat = firstNumber * secondNumber)); }
            else if (arithmeticOperation == "Д") { Console.WriteLine("Результат вычисления: " + (resultat = firstNumber / secondNumber)); } 
            else if (arithmeticOperation == "О") { Console.WriteLine("Результат вычисления: " + (resultat = firstNumber % secondNumber)); }
            else if (arithmeticOperation == "Т") { Console.WriteLine("Результат вычисления: " + (Math.Pow(firstNumber, secondNumber))); }
            else {Console.WriteLine("нет такой операции"); }

        }
    }
}

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
            char arithmeticOperation = Convert.ToChar(Console.ReadLine());

            double resultat = 0;
            if (arithmeticOperation == 'C') { resultat = firstNumber + secondNumber; }
            if (arithmeticOperation == 'В') { resultat = firstNumber - secondNumber; }
            if (arithmeticOperation == 'У') { resultat = firstNumber * secondNumber; }
            if (arithmeticOperation == 'Д') { resultat = firstNumber / secondNumber; }
            if (arithmeticOperation == 'О') { resultat = firstNumber % secondNumber; }
            if (arithmeticOperation == 'Т') { resultat = Math.Pow(firstNumber, secondNumber); }
            else {Console.WriteLine("нет такой операции"); }

            Console.WriteLine("Результат вычисления:" + resultat);
        }
    }
}

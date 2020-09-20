using System;

namespace ConsoleApp3
{
    enum Figura
    {
        Note,
        Сircle,
        Triangle,
        Rectangle
    }

    class Program
    {
        static void Main(string[] args)
        {

            double paramFiguraOne, paramFiguraTwo, resultat;
            Figura figuraV = 0;


            figuraV = ReadNumberFigura("Введите тип фигуры (1 круг, 2 равносторонний треугольник, 3 прямоугольник):");

            if (figuraV == 0)
            {
                Console.WriteLine("Ошибка! Такой фигуры не существует!");
            }
            else
            {

                switch (figuraV)
                {
                    case Figura.Сircle:

                        paramFiguraOne = ReadNumberWithoutException("Введите диаметр круга:");
                        Convert.ToDouble(paramFiguraOne);
                        resultat = Math.PI * Math.Pow((paramFiguraOne / 2), 2);
                        Console.WriteLine("Площадь поверхности: " + resultat);
                        resultat = Math.PI * paramFiguraOne;
                        Console.WriteLine("Длина периметра: " + resultat);

                        break;

                    case Figura.Triangle:

                        paramFiguraOne = ReadNumberWithoutException("Введите длину стороны:");
                        resultat = Convert.ToDouble(Math.Sqrt(3) / 4) * Math.Pow(paramFiguraOne, 2);
                        Console.WriteLine("Площадь поверхности: " + resultat);
                        resultat = 3 * paramFiguraOne;
                        Console.WriteLine("Длина периметра: " + resultat);

                        break;

                    case Figura.Rectangle:

                        paramFiguraOne = ReadNumberWithoutException("Введите ширину прямоугольника:");
                        paramFiguraTwo = ReadNumberWithoutException("Введите высоту прямоугольника:");
                        resultat = paramFiguraOne * paramFiguraTwo;
                        Console.WriteLine("Площадь поверхности: " + resultat);
                        resultat = 2 * (paramFiguraOne + paramFiguraTwo);
                        Console.WriteLine("Длина периметра: " + resultat);

                        break;
                }
            }
        }

        static double ReadNumberWithoutException(string caption)
        {
            double a = 0;
            for (; ; )
            {
                Console.WriteLine(caption);
                var number = Console.ReadLine();
                if (double.TryParse(number, out a))
                {
                    return Convert.ToDouble(number);
                }
            }
        }

        static Figura ReadNumberFigura(string caption)
        {
            for (; ; )
            {
                Console.WriteLine(caption);
                Figura a = 0;
                var number = Enum.TryParse(Console.ReadLine(), out a);
                if (number)
                {
                    return a;
                }
            }
        }
    }
}
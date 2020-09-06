using System;

namespace ConsoleApp1
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

            if (figuraV.ToString() == "Note")
            {
                Console.WriteLine("Ошибка! Такой фигуры не существует!");
            }
            else
            {

                switch (figuraV)
                {
                    case Figura.Сircle:
                        try
                        {
                            paramFiguraOne = ReadNumberWithoutException("Введите диаметр круга:");
                            Convert.ToDouble(paramFiguraOne);
                            resultat = Math.PI * Math.Pow((paramFiguraOne / 2), 2);
                            Console.WriteLine("Площадь поверхности: " + resultat);
                            resultat = Math.PI * paramFiguraOne;
                            Console.WriteLine("Длина периметра: " + resultat);
                        }
                        catch (System.FormatException)
                        {

                            Console.WriteLine("Ошибка! Введено нечисловое значение!");
                        }
                        break;

                    case Figura.Triangle:
                        try
                        {
                            paramFiguraOne = ReadNumberWithoutException("Введите длину стороны:");
                            resultat = Convert.ToDouble(Math.Sqrt(3) / 4) * Math.Pow(paramFiguraOne, 2);
                            Console.WriteLine("Площадь поверхности: " + resultat);
                            resultat = 3 * paramFiguraOne;
                            Console.WriteLine("Длина периметра: " + resultat);
                        }
                        catch (System.FormatException)
                        {

                            Console.WriteLine("Ошибка! Введено нечисловое значение!");
                        }
                        break;

                    case Figura.Rectangle:
                        try
                        {
                            paramFiguraOne = ReadNumberWithoutException("Введите ширину прямоугольника:");
                            paramFiguraTwo = ReadNumberWithoutException("Введите высоту прямоугольника:");
                            resultat = paramFiguraOne * paramFiguraTwo;
                            Console.WriteLine("Площадь поверхности: " + resultat);
                            resultat = 2 * (paramFiguraOne + paramFiguraTwo);
                            Console.WriteLine("Длина периметра: " + resultat);
                        }
                        catch (System.FormatException)
                        {

                            Console.WriteLine("Ошибка! Введено нечисловое значение!");
                        }
                        break;
                }
            }
        }


        static double ReadNumberWithoutException(string caption)
        {
            Console.WriteLine(caption);
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static Figura ReadNumberFigura(string caption)
        {
            Console.WriteLine(caption);
            Figura a = 0;
            var number = Enum.TryParse(Console.ReadLine(), out a);
            return a;
        }
    }
}
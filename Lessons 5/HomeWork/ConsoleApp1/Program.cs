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

            double paramFiguraOne, paramFiguraTwo, resultat, figura = 0;
            Figura t = 0;

            try
            {
                figura = ReadNumberWithoutException("Введите тип фигуры (1 круг, 2 равносторонний треугольник, 3 прямоугольник):");
            }
            catch (Exception)
            {

                t = (Figura)0;
            }



            switch (figura)
            {
                case 1:
                    t = (Figura)1;
                    break;
                case 2:
                    t = (Figura)2;
                    break;
                case 3:
                    t = (Figura)3;
                    break;
                default:
                    t = (Figura)0;
                    break;


            }

            if (t == Figura.Сircle)
            {
                try
                {
                    paramFiguraOne = ReadNumberWithoutException("Введите диаметр круга:");
                    Convert.ToDouble(paramFiguraOne);
                    resultat = Math.PI * Math.Pow((paramFiguraOne / 2), 2);
                    Console.WriteLine("Площадь поверхности: " + resultat);
                    resultat = Math.PI * paramFiguraOne;
                    Console.WriteLine("Длина периметра: " + resultat);
                }
                catch (Exception)
                {

                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                }

            }

            else if (t == Figura.Triangle)
            {
                try
                {
                    paramFiguraOne = ReadNumberWithoutException("Введите длину стороны:");
                    resultat = Convert.ToDouble(Math.Sqrt(3) / 4) * Math.Pow(paramFiguraOne, 2);
                    Console.WriteLine("Площадь поверхности: " + resultat);
                    resultat = 3 * paramFiguraOne;
                    Console.WriteLine("Длина периметра: " + resultat);
                }
                catch (Exception)
                {

                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                }

            }


            else if (t == Figura.Rectangle)
            {
                try
                {
                    paramFiguraOne = ReadNumberWithoutException("Введите ширину прямоугольника:");
                    paramFiguraTwo = ReadNumberWithoutException("Введите высоту прямоугольника:");
                    resultat = paramFiguraOne * paramFiguraTwo;
                    Console.WriteLine("Площадь поверхности: " + resultat);
                    resultat = 2 * (paramFiguraOne + paramFiguraTwo);
                    Console.WriteLine("Длина периметра: " + resultat);
                }
                catch (Exception)
                {

                    Console.WriteLine("Ошибка! Введено нечисловое значение!");
                }

            }


            else if (t == Figura.Note)
            {
                Console.WriteLine("Ошибка! Такой фигуры не существует!");
            }

            ///Console.ReadKey();
        }



        static double ReadNumberWithoutException(string caption)
        {
            Console.WriteLine(caption);
            var number = Convert.ToInt32(Console.ReadLine());
            return number;

        }


    }
}
using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            var a = new Circle(10);
            Console.WriteLine(a.Calculate((double b)=> 3.14 * b * b));

            var b = new Circle(10);
            Console.WriteLine(b.Calculate((double a) => 2 * 3.14 * a));

            var r = new Circle(10);
            Console.WriteLine(r.Calculate((double a) => 2 * a));


        }
    }

    class Circle
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Calculate(Func<double, double> so)
        {
            return so(_radius);
        }

    }

}

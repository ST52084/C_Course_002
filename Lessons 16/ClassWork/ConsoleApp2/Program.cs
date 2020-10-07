using System;
using Calculator.Figura;
using Calculator.Operation;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Circle(10);
            var b = a.Calculate(Operation.S);
            Console.WriteLine(b);

            var c = a.Calculate(Operation.P);
            Console.WriteLine(c);



            var a2 = new Circle(10);
            Console.WriteLine(a2.Calculate((double b2) => 3.14 * b * b2));

            var b2 = new Circle(10);
            Console.WriteLine(b2.Calculate((double a2) => 2 * 3.14 * a2));

            var r2 = new Circle(10);
            Console.WriteLine(r2.Calculate((double a2) => 2 * a2));
        }
    }
}

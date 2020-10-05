using System;
using System.Collections.Generic;

namespace Fibonacci_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            with_yield fibonacci_coll = new with_yield();
            foreach (int item in fibonacci_coll)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.WriteLine("/////////////////////////////////////////////////");

            without_yield fibonacci_coll2 = new without_yield();
            foreach (int item in fibonacci_coll2)
            {
                Console.WriteLine(item);
            }

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int item in Fibonacci(10))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/////////////////////////////////////////////////");
            Fibonacci fibonacci_coll = new Fibonacci();
            foreach (var item in fibonacci_coll)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable Fibonacci(int number)    
        {
            int previous = 0;
            int current = 1;
            int i = 0;
            while (i < number)
            {
                yield return previous;
                int next = previous + current;
                previous = current;
                current = next;
                i++;
            }
        }
    }
}


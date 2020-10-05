using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_V2
{
    class with_yield : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            int previous = 0;
            int current = 1;
            int i = 0;
            int number = 10;
            while (i < number)
            {
                yield return previous;
                int next = previous + current;
                previous = current;
                current = next;
                i++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


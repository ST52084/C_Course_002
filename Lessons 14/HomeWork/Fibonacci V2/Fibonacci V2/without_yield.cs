﻿using System;
using System.Collections;
using System.Collections.Generic;


namespace Fibonacci_V2
{
    class without_yield : IEnumerable<int>
    {
        //public List<int> Fibonacci_coll{get; set;}
        //public List<int> _fibonacci_coll = new List<int>();

        Fibonacci fibonacci_coll = new Fibonacci();

        public IEnumerator<int> GetEnumerator()
        {
            //return (IEnumerator<int>)this;
            return ((IEnumerator<int>)fibonacci_coll.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return GetEnumerator();
            return ((IEnumerator<int>)fibonacci_coll.GetEnumerator());
        }





        
        public class Fibonacci : IEnumerator
        {
            List<int> _fibonacci_coll = new List<int>();
            int _position = 0;
            int _previous = 1;
            int _current = 0;
            int _next;

            public object Current
            {
                get
                {
                    _fibonacci_coll.Add(_previous);
                    return _previous;
                }
            }

            public bool MoveNext()
            {
                if (_position < 10)
                {
                    _position++;
                    _next = _current + _previous;
                    _previous = _current;
                    _current = _next;

                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                _position = 0;
            }

            public IEnumerator GetEnumerator()
            {
                return (IEnumerator)this;
            }
        }
        
    }
}

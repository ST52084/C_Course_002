using System;

namespace Calculator.Figura
{

    public delegate double CircleDelegate(double a);

    public sealed class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Calculate(CircleDelegate operation)
        {
            return operation(_radius);
        }
    }

}

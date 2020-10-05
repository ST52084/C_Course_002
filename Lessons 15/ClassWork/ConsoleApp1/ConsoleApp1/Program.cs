using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var acc1 = new Account<int>(10, "AS");
			acc1.WriteProperties();

			var acc2 = new Account<string>("10", "AS");
			acc2.WriteProperties();

			var acc3 = new Account<Guid>(Guid.NewGuid(), "AS");
			acc3.WriteProperties();
			//////////////////////////////

			var a = new Circle(10);
			var b = a.Calculate(S);
			Console.WriteLine(b);

			var c = a.Calculate(P);
			Console.WriteLine(c);
		}

		public static double S(double r)
		{
			return 3.14*r*r;
		}

		public static double P(double r)
		{
			return 2*3.14 * r;
		}

		// public double Calculate(Func<double, double, operation>);
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
}

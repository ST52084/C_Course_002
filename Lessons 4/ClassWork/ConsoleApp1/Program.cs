using System;

namespace ConsoleApp1
{
	enum Color
	{
		Black = 1,
		Blue = 1 << 1,
		Cyan = 1 << 2,
		Grey = 1 << 3,
		Green = 1 << 4,
		Magenta = 1 << 5,
		Red = 1 << 6,
		White = 1 << 7,
		Yellow = 1 << 8
	}
	class Program
	{

		static void Main(string[] args)
		{
			int[] palitra = new int[4];
			/*
			Console.WriteLine("Введите a,h");
			double a = Convert.ToDouble(Console.ReadLine());
			double h = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Sбок= "+3 * a * h);
			Console.WriteLine("Sполн= " + Convert.ToDouble(3/2) * a * (a * Math.Sqrt(3) + 2 * h));

			double H = Math.Sqrt((h*h - a*a/12));
			Console.WriteLine("V= " + Math.Pow(a, 2)/2 * H * Math.Pow(a, 3));
			Console.ReadLine();
			*/

			for (int i = 0; i < palitra.Length; i++)
			{
				Console.WriteLine("Введите номер избранного цвета:");
				palitra[i] = Convert.ToInt32(Console.ReadLine());
			}
			Color a = 0;

			Console.WriteLine("Избранные цвета:");
			for (int i = 0; i < palitra.Length; i++)
			{
				Color t = (Color)palitra[i];
				Console.WriteLine(t);
				a = a | t;

			}


			Console.WriteLine("Все цвета:");
			Color b = (Color)0b11111111;
			Console.WriteLine(b);

			Console.WriteLine("Не избранные цвета:");
			Color c = b ^ a;
			Console.WriteLine(c);








		}
	}
}

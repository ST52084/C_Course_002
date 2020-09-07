using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine("Введите 2 вещественных числа (дробных):");
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine(a + " * " + b + " = " + a*b); /// сложение

			string s = String.Format("{0} * {1} = {2}", a, b, a*b); /// форматирование
			Console.WriteLine(s);

			string ss = $"{a} * {b} = {a*b}";   /// интерполяция
			Console.WriteLine(ss);
			*/

			string text = "     lorem     ipsum    dolor  sit    aet   ";

			Console.WriteLine(text.Trim());  /// удаляем пробелы в конце и начале строки

			string[] arr = text.Trim().Split(" ",StringSplitOptions.RemoveEmptyEntries);   /// делим строку на массив по заданному символу

			arr[1] = arr[1].ToUpper();

			Console.WriteLine(string.Join(" ", arr));


			string ss = text.TrimEnd(' ');
			///Console.WriteLine(ss);

			int p = ss.LastIndexOf(' ');    /// возвращаем индекс заданного символа
			//ss.Substring(0, p);
			Console.WriteLine(ss.Substring(0, p));   /// удаляем строку по индексам

		}
	}
}

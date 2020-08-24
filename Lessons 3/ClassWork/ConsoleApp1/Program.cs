using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			object a = 5;
			int b = (int) a + 5;  //приведение типов

			Console.WriteLine(b);
			*/
			string[] mas = new string [5];
				for (int i = 0; i < mas.Length; i++)
				{
				mas[i] = Console.ReadLine();
				}

			for (int i = 0; i < mas.Length; i++)
			{
				Console.WriteLine(mas[i]);
			}



		}
	}
}

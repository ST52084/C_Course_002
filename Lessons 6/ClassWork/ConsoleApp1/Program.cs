using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine("Hello World!");
			string a;
			do
			{
				a = Console.ReadLine();
				if (a == "Exit")
				{
					break;
				}
			} while ((a.Length > 15));
			*/
			/////////////////////////////////////////
			/*
			string a;
		
			do
			{
				a = Console.ReadLine();
				if (a.Length <= 15)
				{
					Console.WriteLine("Entered string length is: " + a.Length);
					continue;
				}
				
					Console.WriteLine("Too long string. Try another:" + a.Length);
				

			} while (a != "Exit");
			*/
			/*
			int[] array = new int[4] { 1, 2, 3, 5 };
			int a = 0, sum = 0; 
			while (a < array.Length)
			{
				Console.WriteLine(sum = sum + array[a]);
				++a;
			}
			*/
			////////////

			////////////	////////////	////////////	////////////	////////////	////////////

			/*
			var marks = new int[][]
			{
				new[] {2,3,3,2,3 },
				new[] {2,4,5,3 },
				null,
				new[] {5,5,5,5 },
				new[] {4},
			};

			double sum = 0, sumX = 0, sumXX = 0, ocen = 0;

			for (int i = 0; i < marks.Length; i++)
			{
				if (marks[i] != null)
				{

					for (int j = 0; j < marks[i].Length; j++)
					{

						sum = sum + Convert.ToDouble(marks[i][j]);
						sumXX += Convert.ToDouble(marks[i][j]);
						ocen ++;
					}
					sumX = sum / marks[i].Length;
					Console.WriteLine("Средняя оценка за день N" + i + " : " + sumX);
					sum = 0;
					
				}
				else
				{
					Console.WriteLine("N/A");
					continue;
				}
			}
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Средняя оценка за неделю  : " + sumXX / ocen);

			Console.ReadKey();
			*/


			////////////	////////////	////////////	////////////	////////////	////////////


			int dlmas = 0;
			Console.WriteLine("Рзмер массива:");
			dlmas = Convert.ToInt32(Console.ReadLine());
			int[] array = new int[dlmas];

			
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("Элемент массива:");
				array[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("++++++++++++++++++++++++++++");

			foreach (var number in array)
			{
				Console.WriteLine(number);

			}

		}
	}
}

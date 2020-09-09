using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			var doublespis = new List<double>();

			Console.WriteLine("Введите цифру:");

			string a;
			double result = 0;

			do
			{
				a = (Console.ReadLine());

				try
				{
					doublespis.Add(Convert.ToDouble(a));
				}
				catch (FormatException)
				{

					Console.WriteLine("Ошибка");
					///throw;
				}
				

			} while (a != "Stop");

			
			// Вывод элементов списка.
			foreach (var item in doublespis)
			{
				Console.WriteLine(item);
			}
			


			for (int i = 0; i < doublespis.Count; i++)
			{
				result += doublespis[i];
				
			}
	
			Console.WriteLine("Сумма: " + result);
			Console.WriteLine("Сумма: " + result / doublespis.Count);

			//////////////////////
			

			Dictionary<string, string> dic = new Dictionary<string, string>();

			dic.Add("Россия", "Москва");
			dic.Add("Франция", "Париж");
			dic.Add("Англия", "Лондон");

			string otvet;


			do
			{
				Console.WriteLine("Какая столица:");
				Console.WriteLine(dic["Россия"]);
				otvet = Console.ReadLine();

			} while (dic.TryGetValue("Россия") == dic.TryGetValue(otvet));
			///////////////////////////////// НУЖНО ДОДЕЛАТЬ

			//////////////////////////////////

	

			//////////////////////////////////
			Queue<double> ocer = new Queue<double>();

			string a;
			do
			{
				a = Console.ReadLine();

				if (a == "run")
				{
					while (ocer.Count > 0)
					{
						var b = ocer.Dequeue();
						Console.WriteLine(b * b);
					}
					break;
				}

				if (a == "exit")
				{
					Console.WriteLine(ocer.Count);
					break;

				}
				else
				{
					ocer.Enqueue(Convert.ToDouble(a));
				}

			} while (true);

	*/
			Stack<int> ocer = new Stack<int>();
			string a;

			do
			{
				Console.WriteLine("Введите команду");
				a = Console.ReadLine();

				if (a == "wash")
				{
					ocer.Push(1);
					Console.WriteLine("Тарелок: " + ocer.Count);
					
				}
				if (a == "dry")
				{
					if (ocer.Count > 0)
					{
						ocer.Pop();
						Console.WriteLine("Тарелок: " + ocer.Count);
					}
					else
					{
						Console.WriteLine("Нет тарелок");
					}
				}
				if (a == "exit")
				{
					Console.WriteLine("Тарелок: " + ocer.Count);
					break;
				}
				

				



			} while (true);
			




		}

	}
}

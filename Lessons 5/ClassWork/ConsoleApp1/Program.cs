using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine("Введите востраст цифрами:");
			int input = Convert.ToInt32(Console.ReadLine());
			var quotier = input % 10;
			var divident = input / 10;
			if (input/2 == ) 
			{

			}	
		
			Console.WriteLine("Введите число менее 100:");
			int input = Convert.ToInt32(Console.ReadLine());
			if (input > 100)
			{
				var ex = new Exception("Ввели число больше 100!");
				throw ex;
				//throw new Exception("Ввели число больше 100!"); /// тоже саме
			}

			Console.ReadKey();
				*/

			try
			{
				Console.WriteLine("Введите первое число:");
				double firstnamber = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите второе число:");
				double secondnamber = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите операцию которую ледует выполнить:");
				Console.WriteLine("(C)Сложение_(В)Вычетание_(У)_Умножение_(Д)Деление)");
				string opera = Console.ReadLine();

				double resultat = 0;
				if (opera == "С")
				{
					resultat = firstnamber + secondnamber;
				}
				if (opera == "В")
				{
					resultat = firstnamber - secondnamber;
				}
				if (opera == "У")
				{
					resultat = firstnamber * secondnamber;
				}
				if (opera == "Д")
				{
					resultat = firstnamber / secondnamber;
				}

				Console.WriteLine("Результата: " + resultat);

			}
			catch (FormatException exception)
			{

				Console.WriteLine("Ввод некорректный");
				
			}

			
		}
	}
}

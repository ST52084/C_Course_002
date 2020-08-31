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

			
				
				double firstnamber = ReadNumberWithoutException("Введите первое число:");    ///Вызываем метод ReadNumberWithoutException
				double secondnamber = ReadNumberWithoutException("Введите второе число:");

		

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


			static double ReadNumberWithoutException (string caption)
			{
				for (;;)
				{
				Console.WriteLine(caption);
					int namber;
					var resultat = int.TryParse(Console.ReadLine(), out namber);
					if (resultat)
					{
						return namber;
					}
				}
			}
			
		
	}
}

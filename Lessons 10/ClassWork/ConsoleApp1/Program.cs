using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var pet = new Pet();
			var pet2 = new Pet();

			pet.Kind = "Cat";
			pet.Name = "Tom";
			pet.Sex = 'M';
			pet.Age = 2;

			Console.WriteLine(pet.Description);
			

		}
	}
}

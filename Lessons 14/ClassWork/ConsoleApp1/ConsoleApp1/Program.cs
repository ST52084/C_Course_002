using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            using (var errorList = new ErrorList("Program Errors"))
            {
                errorList.Add("I/O error");
                errorList.Add("Some unknown error");

                foreach (var error in errorList)
                {
                    Console.WriteLine(errorList.Category + ": " + error);
                }
            }


		}
	}
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new BaseDocument("Pass", "00-01", DateTimeOffset.Parse("01.01.2018"));
            //var person01 = new Passport("Rus", "Tom", "00-01", DateTimeOffset.Parse("01.01.2018"));
            //var person = new BaseDocument();
            //person.Title = "Pass";
            //person.Number = "00-01";
            //person.IssueData = DateTimeOffset.Parse("01.01.2018");

            //var person01 = new Passport();
            //person01.Title = "Pass01";
            //person01.Number = "00-02";
            //person01.IssueData = DateTimeOffset.Parse("01.01.2017");
            //person01.Country = "Rus";
            //person01.PersonName = "Tom";

            //person.WriteToConsole();
            //person01.WriteToConsole();

            var Pas = new BaseDocument[]
            {
            new BaseDocument("Pass", "00-01", DateTimeOffset.Parse("01.01.2018")),
            new Passport("Rus", "Tom", "00-01", DateTimeOffset.Parse("01.01.2018")),
        };

            foreach (var item in Pas)
            {
                if (item is Passport passport)
                {
                    passport.ChangeissueDate(DateTime.Now);
                }
                item.WriteToConsole();

            }


        }
    }
}

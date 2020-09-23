using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BaseDocument
    {
        public string Title;
        public string Number;
        public DateTimeOffset IssueData;
        public virtual  string Description =>
          $"Title: {Title}, Number: {Number}, IssueData: {IssueData}";


        public BaseDocument(string title, string number, DateTimeOffset iossueData)   
        {
            Title = title;
            Number = number;
            IssueData = iossueData;
        }


        public void WriteToConsole()
        {
            Console.WriteLine(Description);
        }

    }

    class Passport : BaseDocument
    {
        public string Country;
        public string PersonName;

        public Passport(string country, string persoName, string number, DateTimeOffset iossueData) : base("Pasport", number, iossueData)
        {
            
            Country = country;
            PersonName = persoName;
        }

        public override string Description =>
         $"Title: {Title}, Number: {Number}, IssueData: {IssueData}, Country: {Country}, PersonName: {PersonName}";

        //public new void WriteToConsole()
        //{
        //    Console.WriteLine(Description);
        //}

        public void ChangeissueDate(DateTimeOffset newlssuseDate)
        {
            IssueData = DateTime.Now;
        }
    }
}

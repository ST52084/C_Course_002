using System;
using System.Collections.Generic;

namespace Dictionary_of_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("Россия", "Москва");
            countries.Add("Италия", "Рим");
            countries.Add("Украина", "Киев");
            countries.Add("Франция", "Париж");
            countries.Add("Англия", "Лондон");
            string stolica, dicCountry;

            do
            {
                Random rnd = new Random();
                string[] rdCountries = { "Россия", "Италия", "Украина", "Франция", "Англия" };
                int сIndex = rnd.Next(rdCountries.Length);
                dicCountry = countries[rdCountries[сIndex]];

                Console.WriteLine("Назовите столицу " + rdCountries[сIndex]);
                stolica = Console.ReadLine();


                if (stolica == dicCountry)
                {
                    Console.WriteLine("Верно!");
                }
                else
                {
                    Console.WriteLine("Не верно!");
                    break;
                }

            } while (stolica == dicCountry);




            /*          ///цифкл перебирает все значения словаря
                        foreach (KeyValuePair<string, string> keyValue in countries)
                        {   
                            Console.WriteLine($"{keyValue.Key}-{keyValue.Value}");

                        }
            */

            //string country = countries["Россия"];   ////getting elements by key
            //Console.WriteLine(country);




        }
    }
}

using System;

namespace ConsoleApp1
{
    [Flags]
    enum Conteiner : byte
    {
        None =      0b0000,  //0
        Liter1 =    0b0001,  //1
        Liter5 =    0b0010,  //2
        Liter20 =   0b0100   //4
    }


    class Program
    {
        static void Main(string[] args)
        {

            var allConteiner = Conteiner.None;
            int rezul = 0;

            Console.WriteLine("Какой объем сока в литрах требуется упаковать ?");
            double sokV = Convert.ToDouble(Console.ReadLine());

            int L20 = Convert.ToInt32(Math.Floor(sokV / 20));
            int L5 = Convert.ToInt32(Math.Floor((sokV - L20 * 20) / 5));
            int L1 = Convert.ToInt32(Math.Ceiling((sokV - (L20 * 20) - (L5 * 5)) / 1));

            if (L20 > 0)
            {
                allConteiner = (Conteiner)(allConteiner | Conteiner.Liter20);
            }

            if (L5 > 0)
            {
                allConteiner = (Conteiner)(allConteiner | Conteiner.Liter5);
            }

            if (L1 > 0)
            {
                allConteiner = (Conteiner)(allConteiner | Conteiner.Liter1);
            }

            rezul = Convert.ToInt32(allConteiner);


            Console.WriteLine("Вам потребуются следующие контейнеры:");

            bool isConteiner = (((rezul) & 0b0100) > 0);
            if (isConteiner == true)
            {
                Console.WriteLine("20л: \t" + L20 +" шт.");
            }

            isConteiner = (((rezul) & 0b0010) > 0);
            if (isConteiner == true)
            {
                Console.WriteLine("5л: \t" + L5 + " шт.");
            }

            isConteiner = (((rezul) & 0b0001) > 0);
            if (isConteiner == true)
            {
                Console.WriteLine("1л: \t" + L1 + " шт.");
            }


        }
    }
}

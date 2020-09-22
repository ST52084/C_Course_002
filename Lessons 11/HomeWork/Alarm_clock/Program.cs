using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm_clock
{
    class Program
    {
        static void Main(string[] args)
        {
            var alarm_clock01 = new ReminderItem(DateTimeOffset.Parse("23.09.2020 23:00:00"), "Подъём!");
            var alarm_clock02 = new ReminderItem(DateTimeOffset.Parse("21.09.2020 23:00:00"), "Подъём!");
            //Console.WriteLine("Текущее время: \t"+ DateTime.Now);
            alarm_clock01.WriteProperties();
            Console.WriteLine("************************************************************************");
            alarm_clock02.WriteProperties();
        }
    }
}

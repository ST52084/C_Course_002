using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm_clock_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ReminderItem> alarm_clock = new List<ReminderItem>();
            alarm_clock.Add(new ReminderItem(DateTimeOffset.Parse("23.09.2019 23:00:00"), "Первый звонок"));
            alarm_clock.Add(new PhoneReminderItem("8800200300", DateTimeOffset.Parse("23.09.2020 23:00:00"), "Второй звонок"));
            alarm_clock.Add(new ChatReminderItem("Big_Chart", "Tom", DateTimeOffset.Parse("23.09.2021 23:00:00"), "Третий звонок"));

            foreach (var item in alarm_clock)
            {
                Console.WriteLine("************************************************************************");
                item.WriteProperties(item.GetType().ToString());
            }

        }
    }
}

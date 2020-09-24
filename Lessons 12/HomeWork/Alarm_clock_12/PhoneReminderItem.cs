using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm_clock_12
{
    class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber;

        public PhoneReminderItem(string phoneNumber, DateTimeOffset alarmDate, string alarmMessage) : base(alarmDate, alarmMessage)
        {
            PhoneNumber = phoneNumber;
        }

        public override void WriteProperties(string typObecta)
        {
            Console.WriteLine($"Тип объекта: \t {typObecta}" +
                $"\nДата и время будильника:  \t {AlarmDate}" +
                $"\nСообщение будильника:  \t {AlarmMessage}" +
                $"\nВремя до срабатывания: \t {TimeToAlarm}" +
                $"\nПросрочено ли событие: \t {IsOutdated}" +
                $"\nНомер телефона: \t {PhoneNumber}");
        }

    }
}

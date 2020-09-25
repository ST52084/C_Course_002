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

        public override void WriteProperties()
        {
            base.WriteProperties();
            Console.WriteLine(
                $"Номер телефона: \t {PhoneNumber}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm_clock_12
{
    class ChatReminderItem : ReminderItem
    {
        public string CharName;
        public string AccountName;

        public ChatReminderItem(string charName, string accountName, DateTimeOffset alarmDate, string alarmMessage) : base(alarmDate, alarmMessage)
        {
            CharName = charName;
            AccountName = accountName;
        }

        public override void WriteProperties()
        {
            base.WriteProperties();
            Console.WriteLine(
                $"Имя чарта: \t {CharName}" +
                $"\nИмя аккаунта: \t {AccountName}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm_clock_12
{
    class ReminderItem
    {
        public DateTimeOffset AlarmDate;
        public string AlarmMessage;

        public ReminderItem(DateTimeOffset alarmDate, string alarmMessage)
        {
            AlarmDate = alarmDate;
            AlarmMessage = alarmMessage;
        }

        public TimeSpan TimeToAlarm
        {
            get
            {
                return (TimeSpan)(DateTime.Now - AlarmDate);
            }
        }

        public bool IsOutdated
        {
            get
            {
                if (TimeToAlarm >= TimeSpan.Parse("0:00:00"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public virtual void WriteProperties(string typObecta)
        {
            Console.WriteLine($"Тип объекта: \t {typObecta}" +
                $"\nДата и время будильника:  \t {AlarmDate}" +
                $"\nСообщение будильника:  \t {AlarmMessage}" +
                $"\nВремя до срабатывания: \t {TimeToAlarm}" +
                $"\nПросрочено ли событие: \t {IsOutdated}");
        }
    }
}


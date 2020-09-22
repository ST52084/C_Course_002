using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm_clock
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

        private TimeSpan _TimeToAlarm
        {
            get
            {
                return (TimeSpan)(DateTime.Now - AlarmDate);
            }
        }

        private bool _IsOutdated
        {
            get
            {
                if (_TimeToAlarm >= TimeSpan.Parse("0:00:00"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void WriteProperties()
        {
            Console.WriteLine($"Дата и время будильника:  \t {AlarmDate} " +
                $"\nСообщение будильника:  \t {AlarmMessage} " +
                $"\nВремя до срабатывания: \t {_TimeToAlarm}" +
                $"\nПросрочено ли событие: \t {_IsOutdated} ");
        }
    }
}


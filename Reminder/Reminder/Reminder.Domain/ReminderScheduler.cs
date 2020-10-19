using System;
using System.Threading;
using Reminder.Storage;


namespace Reminder.Domain
{
    public class ReminderSentEventArgs


    public class ReminderScheduler
    {
        public event EventHandler<>;

        private readonly IReminderStorage _storage;
        private Timer _timer;

        public ReminderScheduler(IReminderStorage storage)
        {
            _storage = storage ?? throw new ArgumentException(nameof(storage));
        }

        public void Start()
        {
            _timer = new Timer(OnTimerTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
        }

        private void OnTimerTick(object state)
        {
            var datetime = DateTimeOffset.UtcNow;
            var reminders = _storage.Finde(datetime);

            foreach (var reminder in reminders)
            {
                ReminderSent?.Invoke(this, new ReminderSentEventArgs(reminder));
                reminder.MarkSent();
                
            }
        }
    }
}

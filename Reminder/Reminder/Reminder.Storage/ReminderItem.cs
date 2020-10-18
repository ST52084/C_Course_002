using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Storage
{
    public class ReminderItem
    {
        /// <summary>
        /// Uniqe identifier
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// One value from <see cref="ReminderItemStatus"/>
        /// <example>
        ///     var s = Status.Sent;        // пример кодка как можно с ним работать 
        /// </example>
        /// </summary>
        public ReminderItemStatus Status { get; private set; }

        /// <summary>
        /// Date and time to sent in UTC format
        /// </summary>
        public DateTimeOffset DateTime { get; private set; }
        public string Message { get; private set; }
        public string ContactId { get; private set; }

        public ReminderItem(Guid id, ReminderItemStatus status, DateTimeOffset dateTime, string message, string contactId)
        {
            Id = id;
            Status = status;
            DateTime = dateTime;
            Message = message;
            ContactId = contactId;
        }
        public override string ToString() =>
            $"Reminder (id:{Id}, status : {Status}) at {DateTime:O} to {ContactId}";

    }
}

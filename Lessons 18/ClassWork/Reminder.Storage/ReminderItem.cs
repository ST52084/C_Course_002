using System;

namespace Reminder.Storage
{
    /// <summary>
    /// Represent one reminder
    /// </summary>
    public class ReminderItem
    {
        /// <summary>
        /// Unique identifier
        /// </summary>

        public Guid Id { get;}
        public ReminderItemStatus Status { get; private set; }
        public DateTimeOffset Datetime { get; private set; }
        public string Message { get; private set; }
        public string ContactId { get; private set; }

        public ReminderItem(Guid id, ReminderItemStatus status, DateTimeOffset datetime, string message, string contactId)
        {
            Id = id;
            Status = status;
            Datetime = datetime;
            Message = message;
            ContactId = contactId;
        }
        public override string ToString()
        {
            return $"Reminder (Id : { Id}, status : {Status}) at {Datetime : 0} to {ContactId}";
        }
    }
}

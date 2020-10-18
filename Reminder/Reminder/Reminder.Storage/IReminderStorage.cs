using System;
using System.Collections.Generic;

namespace Reminder.Storage
{
    public interface IReminderStorage
    {

        void add(ReminderItem item);
        void Update(ReminderItem item);
        /// <summary>
        /// Renurns item with matching by id
        /// </summary>
        /// <param name="id">The reminder id</param>
        /// <exception cref="ReminderItemNotFoundException">Raises if item with specified id is not found</exception>
        /// <returns>
        ///     The reminder <see cref="ReminderItem"/>
        /// </returns>
        ReminderItem Get(Guid id);
        ReminderItem[] Fine(DateTimeOffset datetime);
    }

}

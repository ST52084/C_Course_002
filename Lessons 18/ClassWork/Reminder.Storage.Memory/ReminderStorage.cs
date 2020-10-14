using System;
using System.Collections.Generic;
using Reminder.Storage.Exceptions;
using System.Linq;

namespace Reminder.Storage.Memory
{
    public class ReminderStorage : IReminderStorage
    {
       


        private readonly Dictionary <Guid, ReminderItem> _items;

        public ReminderStorage()
        {
            _items = new Dictionary <Guid, ReminderItem>();
        }


        public void Add(ReminderItem item)
        {
            throw new NotImplementedException();
        }

        public ReminderItem[] Finde(DateTimeOffset datetime)
        {
            //return _items
            //    .Where(pair => pair.Value.Datetime <= datetime)
            //    .Select(pair => pair.Value)
            //    .OrderByDescending(item => item.Datetime)
            //    .ToArray();

            return _items.Values
                .Where(item => item.Datetime <= datetime)
                .OrderByDescending(item => item.Datetime)
                .ToArray();
        }

        public ReminderItem Get(Guid id)
        {

            // Contains + index -> TryGetValue
            var found = _items.TryGetValue(id, out var item);
            if (!found)
            {
                throw new ReminderItemNotFoundException(id);
            }
            return item;

        }

        public void Update(ReminderItem item)
        {
            throw new NotImplementedException();
        }
    }
}

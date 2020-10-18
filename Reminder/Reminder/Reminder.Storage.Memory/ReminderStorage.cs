using System;
using System.Collections.Generic;
using System.Linq;
using Reminder.Storage.Exceptions;

namespace Reminder.Storage.Memor
{
    
    public class ReminderStorage : IReminderStorage
    {
        private readonly Dictionary<Guid, ReminderItem> _items;
        public ReminderStorage()
        {
            _items = new Dictionary<Guid, ReminderItem>();
        }

        public ReminderStorage(params ReminderItem[] items)
        {
            _items = items.ToDictionary(item => item.Id);
        }

        public void add(ReminderItem item)
        {
            throw new NotImplementedException();
        }

        public ReminderItem[] Fine(DateTimeOffset datetime)
        {
            // item <-> IEnumerable <KeyValuePair, Guid, ReminderItem>>
            //return _items
            //    .Where(pair => pair.Value.DateTime <= datetime)     // фильтруем <= datetime
            //    .Select(pair => pair.Value)                         // меняем тип на Value
            //    .OrderByDescending(item => item.DateTime)           // сортируем в обратном порядке
            //    .ToArray();                                         // метод делаем массив

                    // тоже самое, но быстрее
            return _items.Values
                .Where(items => items.DateTime <= datetime)         // фильтруем <= datetime                
                .OrderByDescending(item => item.DateTime)           // сортируем в обратном порядке
                .ToArray();                                         // метод делаем массив
        }

        public ReminderItem Get(Guid id)
        {
            // ContainsKey + indexer -> TryGetValue
            if (!_items.TryGetValue(id, out var item))
            {
                //сгенерировать собственный тип исключения
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

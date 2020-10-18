using System;
using NUnit.Framework;
using Reminder.Storage.Exceptions;
using Reminder.Storage.Memor;

namespace Reminder.Storage.Memory.Tests
{
    public class ReminderStorageTests
    {
        [Test]
        public void Get_GivenNotExistingId_ShouldRaiseException()
        {
            var storage = new ReminderStorage();
            var itemId = Guid.NewGuid();                                            //генерируем Guid

            var exception = Assert.Catch<ReminderItemNotFoundException>(() =>        //ловим исключение
                storage.Get(itemId));

            Assert.AreEqual(itemId, exception.Id);

        }


        [Test]
        public void Get_GivenExistingItem_ShouldReturnIt()
        {
            // Arrange
            var itemId = Guid.NewGuid();
            var item = ReminderItem(itemId);
            var storage = new ReminderStorage(item);
            // Act
            var result = storage.Get(itemId);
            // Assert
            Assert.AreEqual(itemId, result.Id);
        }


        public ReminderItem ReminderItem(Guid id)
        {
            return new ReminderItem(id,
                ReminderItemStatus.Created,
                DateTimeOffset.UtcNow,
                "Message",
                "ContactId");
        }

        void Test(ReminderStorage storage, Guid itemId)
        {
            storage.Get(itemId);
        }
    }
}

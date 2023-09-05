using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using ProjectGenerics.Events;

namespace ProjectGenerics.Notifications
{
    public static class StorageNotification
    {
        /// <summary>
        ///  хранилище уведомлений
        /// </summary>
        
        public static List<Notification<EventType>>? NewNotifications { get; set; }
        public static List<Notification<EventType>>? OldNotifications { get; set; }

        public static void UnpackingNotifications() // проверка новых уведомлений, не пора ли им выводиться
        {
            if (NewNotifications == null) throw new InvalidOperationException("список невыведенных уведомлений пуст!");
            foreach(var notification in NewNotifications)
            {
                notification.CheckingTime(notification);
            }
        }

        public static void WriteDown() // сериализация списка новых уведомлений в json
        {
            string objectSerialized = JsonSerializer.Serialize(NewNotifications);
            File.WriteAllText("NewNotifications.json", objectSerialized);
        }
    }
}

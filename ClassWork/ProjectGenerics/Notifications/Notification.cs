using ProjectGenerics.Events;

namespace ProjectGenerics.Notifications
{
    public class Notification<T> : IPrint where T: EventType
    {
        /// <summary>
        /// основной класс программы - класс уведомления. Общая структура уведомления, можно задавать уведомления различных типов. 
        /// </summary>

        public Notification(DateTime dateTimeNotification, int code, EventType eventType)
        {
            DateTimeNotification = dateTimeNotification;
            Code = code;
            AddOnCreated();
            EventType = eventType;
        }

        public T? Type { get; set; }
        public DateTime DateTimeNotification { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Code { get; set; }
        public EventType EventType { get; set; }
        public List<User>? Users { get; set; }

        public void AddOnCreated() // добавляет данное уведомление в список невыведенных уведомлений, если дата события еще не прошла и сразу сериализует этот список в json, а если дата уже прошла то в список старых уведомлений
        {
            if (this.DateTimeNotification > DateTime.Now)
            {
                StorageNotification.NewNotifications?.Add((this as Notification<EventType>)!);
                StorageNotification.WriteDown();
            }
            else
            {
                StorageNotification.OldNotifications?.Add((this as Notification<EventType>)!);
            }
        }

        public void CheckingTime(Notification<EventType> notification) // проверяет время и если оно совпадает с настоящим, то выводит его, и затем переводит уведомление в список старых
        {
            if(notification.DateTimeNotification == DateTime.Now)
            {
                notification.Print();
            }
            StorageNotification.NewNotifications!.Remove(notification);
            StorageNotification.WriteDown();
            StorageNotification.OldNotifications!.Add(notification);
        }

        public void Print() // вывод уведомления для каждого пользователя
        {
            foreach(var user in GetNowListSubcsribedUsers(Users!))
            {
                Console.WriteLine("Уведомление выведено!");
            }
        }

        public List<User> GetNowListSubcsribedUsers(List<User> users) // получение списка пользователей, которые имеют подписку на уведомления
        {
            return users.Where(user => user.Subscribition == true).ToList();
        }
    }
}

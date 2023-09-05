using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGenerics.Notifications
{
    public class User 
    {
        /// <summary>
        /// класс пользователя некоторой программы, для которой я реализую систему уведомлений
        /// </summary>

        public User(string name, bool subscribition, DateOnly dateCreate)
        {
            Name = name;
            Subscribition = subscribition;
            DateCreate = dateCreate;
            DateUserCreate?.Add(this, dateCreate);
            this.Birthday += UserBirthday;
        }

        public int Id { get; init; }
        public string Name { get; set; }
        public bool Subscribition { get; set; }
        public DateOnly BirthdayDate { get; set; }
        public DateOnly DateCreate { get; init; }

        public event Action Birthday;
        public void Celebrate(User user) // проверяем, на совпадение с настоящим временем и вызываем событие дня рождения
        {
            if (user.BirthdayDate == DateOnly.FromDateTime(DateTime.Now))
                Birthday?.Invoke();
        }

        public Dictionary<User, DateOnly>? DateUserCreate { get; set; }
        
        public List<User> GetUsersDateCreate(List<User> users, DateOnly date) // получение список пользователей, у которых дата создания профиля позже определенной другой даты
        {
            return users.Where(u => u.DateCreate <= date).ToList();
        }

        private static void UserBirthday() // вывод поздравления
        {
            Console.WriteLine($"С днем рождения!");
        }
    }
}

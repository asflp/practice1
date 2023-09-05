using ProjectGenerics.Events;
using ProjectGenerics.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGenerics
{
    public class Program
    {
        static void Main()
        {
            var library = new NotificationLibrary();
            User user1 = new User("Olga", true, new DateOnly(2023, 5, 1));
            StorageNotification.UnpackingNotifications();
        }
        
    }
}


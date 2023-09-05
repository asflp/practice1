using NPOI.SS.Formula.Functions;
using ProjectGenerics.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGenerics.Notifications
{
    public class NotificationLibrary
    {
        public static Func<DateTime, DateTime> GiveDateTimeNotification = (dateTime) => dateTime.AddDays(-3);

        public NotificationLibrary()
        {
            Song song1 = new Song("bj", "hjk", new DateTime(2023, 6, 23));
            Notification<EventType> notSong1 = new Notification<EventType>(GiveDateTimeNotification(song1.DateTimeEvent), 1000, song1);

            Concert conc1 = new Concert("somename", "Timati", "АкБарс арена");
            Notification<EventType> notConc1 = new Notification<EventType>(new DateTime(2023, 6, 4), 1000, conc1);
        }  
    }
}
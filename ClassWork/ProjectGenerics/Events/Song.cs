using ProjectGenerics.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGenerics
{
    public class Song : EventType
    {
        /// <summary>
        /// класс песни (тип события)
        /// </summary>

        public Song(string performer, string name, DateTime dateTime)
        {
            Performer = performer;
            Name = name;
            DateTimeEvent = dateTime;
        }

        public ulong SongId { get; set; }
    }
}

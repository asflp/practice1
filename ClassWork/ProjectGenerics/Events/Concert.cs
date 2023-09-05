using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGenerics.Events
{
    public class Concert : EventType
    {
        /// <summary>
        /// класс концерт (тип события) 
        /// </summary>

        public Concert(string name, string performer, string location)
        {
            Name = name;
            Performer = performer;
            Location = location;
        }
        public string? Type { get; set; }
        public string Location { get; set; }
    }
}

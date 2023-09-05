using NPOI.Util.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGenerics.Events
{
    public class EventType
    {

        /// <summary>
        /// базовый класс для вида события
        /// </summary>
        
        public string? Performer { get; set; }
        public string? Name { get; set; }
        public DateTime DateTimeEvent { get; set; }
    }
}

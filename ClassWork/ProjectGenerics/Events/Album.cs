using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGenerics.Events
{
    public class Album : EventType
    {
        /// <summary>
        /// класс альбом (тип события) 
        /// </summary>
        
        public Album(string name, string description, ulong albumId, string performer)
        {
            Name = name;
            Description = description;
            AlbumId = albumId;
            Performer = performer;
        }

        public string Description { get; set; }
        public ulong AlbumId { get; }
        public List<Song>? Songs { get; set; }
    }
}

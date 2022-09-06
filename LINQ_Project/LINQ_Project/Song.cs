using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    public class Song
    {
        public Song() { }
        public Song(int id, int albumId, string name, int duration)
        {
            Id = id;
            AlbumId = albumId;
            Name = name;
            Duration = duration;
        }



        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// duration in seconds
        /// </summary>
        public int Duration { get; set; }
        public object Songs { get; internal set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

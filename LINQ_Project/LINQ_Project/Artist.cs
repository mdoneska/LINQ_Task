using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Project
{
    public class Artist
    {
        #region Ctors
        public Artist() { }
        public Artist(int id, string fullName, ArtistType artistType)
        {
            Id = id; FullName = fullName; ArtistType = artistType;
        }
        #endregion

        #region Properties

        public int Id { get; set; }
        public string FullName { get; set; }
        public ArtistType ArtistType { get; set; }
        public List<Album> Albums { get; set; }

        #endregion

        #region Methods
        #endregion
    }
}

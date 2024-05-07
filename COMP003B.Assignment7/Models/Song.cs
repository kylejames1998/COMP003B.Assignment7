using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Song
    {
        public string SongName { get; set; }

        public string Artist { get; set; }

        public string AlbumId { get; set;}

        // Collection navigation property
        public virtual ICollection<AlbumArtist>? AlbumArtists { get; set; }
    }
}

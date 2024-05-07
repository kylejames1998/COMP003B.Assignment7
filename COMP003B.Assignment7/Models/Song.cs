using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Song
    {
        [Required]
        public string SongName { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        public string AlbumId { get; set;}

        // Collection navigation property
        public virtual ICollection<AlbumArtist>? AlbumArtists { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Artist
    {
        [Required]
        public string ArtistName { get; set; }

        public string Genre { get; set; }

        public string Country { get; set; }

        // Collection navigation property
        public virtual ICollection<AlbumArtist>? AlbumArtists { get; set; }
    }
}

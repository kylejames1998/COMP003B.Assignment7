using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class Artist
    {
        [Required]
        public string ArtistName { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Country { get; set; }

        // Collection navigation property
        public virtual ICollection<AlbumArtist>? AlbumArtists { get; set; }
    }
}

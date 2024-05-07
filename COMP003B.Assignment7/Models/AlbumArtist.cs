using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment7.Models
{
    public class AlbumArtist
    {   
        public string ArtistName { get; set; }

        public string AlbumId { get; set; }

        // Nullable navigation properties
        public virtual Artist? Artist { get; set; }
        public virtual Song? Song { get; set; }
    }
}

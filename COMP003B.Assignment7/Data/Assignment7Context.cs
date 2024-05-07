using COMP003B.Assignment7.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.LectureActivity7.Data
{
    public class Assignment7Context : DbContext
    {
        public Assignment7Context(DbContextOptions<Assignment7Context> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<AlbumArtist> AlbumArtists { get; set; }
    }
}
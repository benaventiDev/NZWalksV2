using Microsoft.EntityFrameworkCore;
using NZWalksV2.API.Models.Domain;

namespace NZWalksV2.API.Data
{
    public class NZWalksDbContext: DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk>  Walks{ get; set; } 
    }
}

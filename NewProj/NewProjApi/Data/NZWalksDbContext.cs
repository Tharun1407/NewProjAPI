using Microsoft.EntityFrameworkCore;
using NewProjApi.Models.Domain;

namespace NewProjApi.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options):base(options) 
        {
            
        }

        public DbSet<Region> Regions { get; set; } 

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Walk> Walks { get; set; }

        
    }
}

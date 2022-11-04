using Microsoft.EntityFrameworkCore;
using PracticeProject.API.Models.Domain;

namespace PracticeProject.API.Data
{
    public class PracticeProjDBContext : DbContext
    {

        public PracticeProjDBContext(DbContextOptions<PracticeProjDBContext> options) : base(options)

        {
        
        }   
            public DbSet<Region> Regions { get; set; }
            public DbSet<Walk> Walks { get; set; }
            public DbSet<WalkDifficulty> WalkDifficulties { get; set; }

    }
}
    

    



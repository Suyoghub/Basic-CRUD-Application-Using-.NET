using bulkybookweb.Models;
using Microsoft.EntityFrameworkCore;

namespace bulkybookweb.Data
{
    public class Applicationdbcontext:DbContext

    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { id = 1, Name = "Action", DisplayOrdr = 1 },
                new Category { id = 2, Name = "Scifi", DisplayOrdr = 2 }

                );
        }
    }
    
}

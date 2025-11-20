using Microsoft.EntityFrameworkCore;
using SaurabhPersonal.Models;

namespace SaurabhPersonal.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { ID = 1, Name = "Pinky Shukla", Email = "pinky@gmail.com", Phone=540 },
                new Contact { ID = 2, Name = "Rahul Gupta",  Email = "rahul@gmail.com", Phone=230 }
                );
        }
        }
}

using Microsoft.EntityFrameworkCore;
using UsersCRUDApp.Models;

namespace UsersCRUDApp.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id); // 'Id' is the primary key property
        }
    }
}


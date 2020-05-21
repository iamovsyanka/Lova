using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace Models.Contexts
{
    public class LovaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<UserTest> UserTests { get; set; }

        public LovaContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=LAPTOP-ADTTMHK8\\SQLEXPRESS;Database=LovaApp;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder) => base.OnModelCreating(modelBuilder);
    }
}

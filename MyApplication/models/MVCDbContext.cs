using System.Data.Entity;

namespace MyApplication.Models
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext() : base("name=mvc_db") { }

        public DbSet<Student> Students { get; set; }
    }
}
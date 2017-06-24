using Microsoft.EntityFrameworkCore;
using SchoolAdmin.Core.Entities;

namespace SchoolAdmin.Database
{
    public class DataContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost; initial catalog=SchoolAdmin; Integrated Security=true");
        }
    }
}

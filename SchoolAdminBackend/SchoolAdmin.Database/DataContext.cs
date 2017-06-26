using Microsoft.EntityFrameworkCore;
using SchoolAdmin.Core.Entities;

namespace SchoolAdmin.Database
{
    internal class DataContext: DbContext
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ParentStudent>()
            .HasKey(t => new { t.ParentID, t.StudentId });
            builder.Entity<ParentStudent>()
                .HasOne(ps => ps.Student)
                .WithMany(s => s.StudentParents)
                .HasForeignKey(ps => ps.StudentId);
            builder.Entity<ParentStudent>()
                .HasOne(ps => ps.Parent)
                .WithMany(p => p.ParentChildren)
                .HasForeignKey(ps => ps.ParentID);
            builder.Entity<Visit>().HasKey(t => new {t.StudentId, t.Date});
            builder.Entity<Visit>()
                .HasOne(v => v.Student)
                .WithMany(s => s.Visits)
                .HasForeignKey(v => v.StudentId);
            builder.Entity<Payment>().HasOne(p => p.Student).WithMany(s => s.Payments).HasForeignKey(p => p.StudentId);
            builder.Entity<Course>()
                .HasOne(c => c.School)
                .WithMany(s => s.Cources)
                .HasForeignKey(c => c.SchoolId);
        }
    }
}

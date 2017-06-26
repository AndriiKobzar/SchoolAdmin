using Microsoft.EntityFrameworkCore;
using SchoolAdmin.Core.Entities;

namespace SchoolAdmin.Database
{
    public interface IDataContext
    {
        DbSet<Course> Courses { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Parent> Parents { get; set; }
        DbSet<School> Schools { get; set; }
        DbSet<Payment> Payments { get; set; }
        DbSet<Student> Students { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity: class;
        int SaveChanges();
    }
}

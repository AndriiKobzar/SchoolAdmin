using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAdmin.Core.Entities;
using SchoolAdmin.Database.Repositories;

namespace SchoolAdmin.Database.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<School> SchoolsRepository { get; }
        IRepository<Group> GroupsRepository { get; }
        IRepository<Course> CoursesRepository { get; }
        void Save();
    }
}

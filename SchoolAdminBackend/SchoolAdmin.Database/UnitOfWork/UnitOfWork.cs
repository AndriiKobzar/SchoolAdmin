using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAdmin.Core.Entities;
using SchoolAdmin.Database.Repositories;

namespace SchoolAdmin.Database.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly IDataContext _dataContext;
        public UnitOfWork(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IRepository<School> SchoolsRepository { get; private set; }
        public IRepository<Group> GroupsRepository { get; private set; }
        public IRepository<Course> CoursesRepository { get; private set; }
        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}

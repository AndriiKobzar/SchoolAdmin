using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Core.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public virtual School School { get; set; }
        public int SchoolId { get; set; }
        public virtual List<Group> Groups { get; set; }

    }
}

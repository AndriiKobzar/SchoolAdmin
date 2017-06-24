using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Core.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoUrl { get; set; }
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
        public List<ParentStudent> StudentParents { get; set; }
        public List<Visit> Visits { get; set; }
        public List<Payment> Payments { get; set; }
    }
}

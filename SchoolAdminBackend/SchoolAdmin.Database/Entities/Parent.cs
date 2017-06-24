using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Core.Entities
{
    public class Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsLiceumAlumni { get; set; }
        public virtual List<ParentStudent> ParentChildren { get; set; }
    }
}

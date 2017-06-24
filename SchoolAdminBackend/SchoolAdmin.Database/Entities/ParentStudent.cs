using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Core.Entities
{
    public class ParentStudent
    {
        public int ParentID { get; set;}
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Parent Parent { get; set; }
    }
}

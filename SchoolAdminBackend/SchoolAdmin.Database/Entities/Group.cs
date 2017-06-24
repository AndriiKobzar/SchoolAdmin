using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Core.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public virtual Course Course { get; set; }
        public virtual List<Student> Students { get; set; }

    }
}

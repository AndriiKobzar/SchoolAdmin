using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SchoolAdmin.Core.Entities
{
    public class School
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public virtual List<Course> Cources { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Core.Entities
{
    public class Visit
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
    }
}

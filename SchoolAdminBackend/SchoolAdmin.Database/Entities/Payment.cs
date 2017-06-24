using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Core.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public byte Month { get; set; }
        public int Year { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ReceiptUrl { get; set; }
        public string Comment { get; set; }
    }
}

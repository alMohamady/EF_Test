using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        public string customerTitle { get; set; }

        public string customerName { get; set; } 

        public string fullName { get; set; }

        public decimal price { get; set; }
        public decimal qty { get; set; } 

        public decimal total { get; set; }

        public DateTime createdDate { get; set; }
    }
}

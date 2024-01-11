using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string genderName { get; set; }
    }
}

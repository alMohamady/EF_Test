using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Plese Enter the Name")]
        public string Name { get; set; }

        [MaxLength(5,ErrorMessage ="Max len can't be > 5 chrs")]
        public string? des {  get; set; }

        public ICollection<Student> students { get; set; }
    }
}

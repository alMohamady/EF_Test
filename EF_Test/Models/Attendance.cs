using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        public string DayName { get; set; }

        [ForeignKey("student")]
        public int studentId { get; set; }

        public Student student { get; set; }
    }
}

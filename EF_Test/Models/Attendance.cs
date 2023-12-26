using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    [Table("StudentsAtts", Schema = "std")]
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        public string DayName { get; set; }

        [Column("theName", TypeName = "varchar(20)")]
        public string? name { get; set; }

        [ForeignKey("student")]
        public int studentId { get; set; }

        [NotMapped]
        public DateTime theData { get; set; }

        public Student student { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    //[Index("Name")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public DateTime Birthdate { get; set; }
        public Grade grade { get; set; }

        [ForeignKey("department")]
        public int departmentId { get; set; }
        public Department department { get; set; }

        public ICollection<StudentBook> books { get; set; }

        //[NotMapped]
        //public ICollection<Attendance> attendances { get; set; }
    }
}

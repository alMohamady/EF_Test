﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    //[Index("Name", IsUnique = true, Name = "Ix_my_indexer")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public DateTime Birthdate { get; set; }
        public virtual Grade grade { get; set; }

        [ForeignKey("department")]
        public int departmentId { get; set; }
        public virtual Department department { get; set; }

        public virtual ICollection<StudentBook> books { get; set; }

        //[NotMapped]
        //public ICollection<Attendance> attendances { get; set; }
    }
}

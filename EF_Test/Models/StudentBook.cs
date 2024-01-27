using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test.Models
{
    public class StudentBook
    {
        public int Id { get; set; }

        [ForeignKey("student")]
        public int studentId { get; set; }
        public virtual Student student { get; set; }

        [ForeignKey("book")]
        public int bookId { get; set; }
        public virtual Book book { get; set; }

        public DateTime getDate { get; set; }
    }
}

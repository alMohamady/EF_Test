using EF_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test
{
    public class AppDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connections.sqlConStr);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<StudentBook> StudentBooks { get; set;}
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>().ToTable("myAtt", "mysc");

            modelBuilder.Entity<Attendance>().Property(x => x.DayName)
                .HasMaxLength(14);

            modelBuilder.Entity<Attendance>().Property(x => x.name)
                .HasColumnName("theName")
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Attendance>().Ignore(x => x.theData);
        }
    }
}

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Department>().Property(x => x.des).IsRequired();

            //modelBuilder.Entity<Department>()
            //    .HasMany(p => p.students)
            //    .WithOne(c => c.department)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Student>()
            //        .HasOne(s => s.grade)
            //        .WithOne(g => g.student)
            //        .OnDelete(DeleteBehavior.SetNull);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //modelBuilder.Ignore<Attendance>();
            //modelBuilder.Entity<Attendance>();
            //modelBuilder.Entity<Attendance>().ToTable("atts", a => a.ExcludeFromMigrations());
        }
    }
}

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
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                                  .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Invoice>().Property(x => x.qty)
                        .HasDefaultValue(1);

            modelBuilder.Entity<Invoice>().Property(x => x.createdDate)
                        .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Invoice>().Property(x => x.fullName)
                        .HasComputedColumnSql("[customerTitle] + ' ' + [customerName]");
            modelBuilder.Entity<Invoice>().Property(x => x.total)
                       .HasComputedColumnSql("[price] * [qty]");
        }
    }
}

// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


var db = new AppDbContext();

var stu = db.Students.Include(d => d.department)
                     .Include(g => g.grade)
                     .Include(b => b.books)
                     .ThenInclude(sb => sb.book)
                     .SingleOrDefault(s => s.Id == 3);

Console.WriteLine(stu.department.Name);

foreach (var book in stu.books)
{
    Console.WriteLine(book.book.Name);
}


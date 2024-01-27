// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


var db = new AppDbContext();

var stu = db.Students.SingleOrDefault(s => s.Id == 3);



db.Entry(stu).Reference(d => d.department).Load();
Console.WriteLine(stu.department.Name);


//db.Entry(stu).Collection(st => st.books).Load();

db.Entry(stu).Collection(st => st.books).Query().Where(x => x.bookId == 3).ToList();

foreach (var book in stu.books)
{
    db.Entry(book).Reference(b => b.book).Load();
    Console.WriteLine(book.book.Name);
}


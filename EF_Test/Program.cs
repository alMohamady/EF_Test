// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;

Console.WriteLine("Hello, World!");


using var db = new AppDbContext();

// Insert
//var department = new Department()
//{
//    Name = "Ahmed"
//};
//db.Departments.Add(department);

var department = db.Departments.Find(1);

if (department != null)
{
    Console.WriteLine(department.Name);

    //Edit
    //department.Name = "Class 1";
    //db.SaveChanges();

    //Delete 
    db.Departments.Remove(department);
    db.SaveChanges();
}
else
{
    Console.WriteLine("nothing");
}
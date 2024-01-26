// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


var db = new AppDbContext();

//var departments = new List<Department>() {
//    new Department()
//{
//    Name = "list 1", des = "xyz" ,
//    students = new List<Student>() {
//       new Student() { Name = "S1.1", Email = "S@s.com", Age = 10 , Grade = 10, Birthdate = DateTime.Now },
//       new Student() { Name = "S2.1", Email = "S2@s.com", Age = 11 , Grade = 11, Birthdate = DateTime.Now },
//    }
//},
//        new Department()
//{
//    Name = "list 2", des = "qaz" ,
//    students = new List<Student>() {
//       new Student() { Name = "S1.2", Email = "S@s.com", Age = 10 , Grade = 10, Birthdate = DateTime.Now },
//       new Student() { Name = "S2.2", Email = "S2@s.com", Age = 11 , Grade = 11, Birthdate = DateTime.Now },
//    }
//},

//    };
//db.Departments.AddRange(departments);

//var dep = db.Departments.Find(7);

//if (dep != null)
//{
//    dep.Name = "new val 1";
//    dep.des = "12345";
//}


//var stu = new Student()
//{
//    Id = 11,
//    Name = "S2.2 new1",
//    Email = "S2@s.com new1",
//    Age = 15,
//    Grade = 15,
//    Birthdate = DateTime.Now,
//    departmentId = 1
//};
//db.Update(stu);
//db.Entry(db.Students.Find(11)).CurrentValues.SetValues(stu);
//db.Entry(db.Students.Find(11)).Property(p => p.Name).IsModified = false; 

var departments = new List<Department>() {
    new Department()
{
    Id = 6,  Name = "edit 1", des = "xyz" ,
    students = new List<Student>() {
       new Student() { Id= 8, Name = "edit S1.1", Email = "S@s.com", Age = 10 , Grade = 10, Birthdate = DateTime.Now },
       new Student() { Id= 9, Name = "edit S2.1", Email = "S2@s.com", Age = 11 , Grade = 11, Birthdate = DateTime.Now },
    }
},
        new Department()
{
    Id = 7, Name = "eidt 2", des = "qaz" ,
    students = new List<Student>() {
       new Student() { Id= 10, Name = "edit S1.2", Email = "S@s.com", Age = 10 , Grade = 10, Birthdate = DateTime.Now },
       new Student() { Id= 11, Name = "edit S2.2", Email = "S2@s.com", Age = 11 , Grade = 11, Birthdate = DateTime.Now },
    }
},
};


db.Departments.UpdateRange(departments);

db.SaveChanges();
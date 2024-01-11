// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


var db = new AppDbContext();

var departments = new List<Department>() {
    new Department()
{
    Name = "list 1", des = "xyz" ,
    students = new List<Student>() {
       new Student() { Name = "S1.1", Email = "S@s.com", Age = 10 , Grade = 10, Birthdate = DateTime.Now },
       new Student() { Name = "S2.1", Email = "S2@s.com", Age = 11 , Grade = 11, Birthdate = DateTime.Now },
    }
},
        new Department()
{
    Name = "list 2", des = "qaz" ,
    students = new List<Student>() {
       new Student() { Name = "S1.2", Email = "S@s.com", Age = 10 , Grade = 10, Birthdate = DateTime.Now },
       new Student() { Name = "S2.2", Email = "S2@s.com", Age = 11 , Grade = 11, Birthdate = DateTime.Now },
    }
},

    };


db.Departments.AddRange(departments);
db.SaveChanges();
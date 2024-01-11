// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


var db = new AppDbContext();

var student = db.Students.SingleOrDefault(x => x.Id == 5 && x.Age > 40);

Console.WriteLine(student.Name);


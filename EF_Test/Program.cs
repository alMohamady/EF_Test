// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


using var db = new AppDbContext();

//var book = new Book() { 
//   Name = "book 1",
//   Author = "Author 1",
//   Created = DateTime.Now,
//};

var uniform = new Uniform()
{
    Name = "uniform 1",
    Created = DateTime.Now,
};

db.uniforms.Add(uniform);
db.SaveChanges();
// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


var db = new AppDbContext();

using var transaction = db.Database.BeginTransaction();

try
{
    db.Departments.Add(new Department { Name = "tarna 11", des = "edc" });
    db.SaveChanges();

    db.Departments.Add(new Department { Name = "tarna 44", des = "edc4" });
    db.SaveChanges();

    transaction.CreateSavepoint("data_ok");

    db.Departments.Add(new Department { Name = "tarna 33", des = "edc1" });
    db.SaveChanges();

    db.Departments.Add(new Department { Name = "tarna 22", des = "edcjjghghghg" });
    db.SaveChanges();


    transaction.Commit();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    //transaction.Rollback();
    try
    {
        transaction.RollbackToSavepoint("data_ok");
        transaction.Commit();
    }
    catch (Exception l2ex)
    {
        Console.WriteLine(l2ex.Message);
        transaction.Rollback();
    }
}




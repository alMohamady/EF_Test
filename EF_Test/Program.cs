// See https://aka.ms/new-console-template for more information
using EF_Test;
using EF_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


var db = new AppDbContext();
//db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

//.AsNoTracking()
var dep = db.Departments.FirstOrDefault(x => x.Id == 2);

dep.Name = "traking test 3";

var track = db.ChangeTracker.Entries();
foreach (var t in track)
{
    Console.WriteLine($"track 1 {t.Entity.ToString()} -> {t.State}");
    t.State = EntityState.Detached;
}


if (track.Any())
{
    foreach (var t in track)
    {
        Console.WriteLine($"track 2 {t.Entity.ToString()} -> {t.State}");
    }
}
else
{
    Console.WriteLine("No tables here");
}

//db.SaveChanges();



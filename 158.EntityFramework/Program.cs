using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=.;Database=StudentDB;Trusted_Connection=True;");
}

class Program
{
    static void Main()
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();

            // CREATE
            var student = new Student { Name = "Raj" };
            db.Students.Add(student);
            db.SaveChanges();

            // READ
            var students = db.Students.ToList();
            Console.WriteLine("Students:");
            foreach (var s in students)
                Console.WriteLine(s.Id + " " + s.Name);

            // UPDATE
            var first = db.Students.FirstOrDefault();
            if (first != null)
            {
                first.Name = "Updated Name";
                db.SaveChanges();
            }

            // DELETE
            var delete = db.Students.FirstOrDefault();
            if (delete != null)
            {
                db.Students.Remove(delete);
                db.SaveChanges();
            }
        }
    }
}
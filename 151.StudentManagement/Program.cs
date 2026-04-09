using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1. Add Student\n2. Display Students\n3. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    DisplayStudents();
                    break;
            }
        } while (choice != 3);
    }

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter Id: ");
        s.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        students.Add(s);
    }

    static void DisplayStudents()
    {
        foreach (var s in students)
        {
            Console.WriteLine($"Id: {s.Id}, Name: {s.Name}");
        }
    }
}
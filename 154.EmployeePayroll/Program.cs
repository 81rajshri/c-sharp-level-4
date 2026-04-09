using System;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
    public double BasicSalary;

    public double CalculateSalary()
    {
        return BasicSalary + (BasicSalary * 0.10); // 10% bonus
    }
}

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1. Add Employee\n2. Display Payroll\n3. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    DisplayPayroll();
                    break;
            }

        } while (choice != 3);
    }

    static void AddEmployee()
    {
        Employee e = new Employee();

        Console.Write("Enter ID: ");
        e.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        e.Name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        e.BasicSalary = double.Parse(Console.ReadLine());

        employees.Add(e);
    }

    static void DisplayPayroll()
    {
        foreach (var e in employees)
        {
            Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Salary: {e.CalculateSalary()}");
        }
    }
}
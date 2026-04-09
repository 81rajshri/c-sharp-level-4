using System;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
}

class Product
{
    public int Id;
    public string Name;
    public int Quantity;
}

class ERPSystem
{
    List<Employee> employees = new List<Employee>();
    List<Product> products = new List<Product>();

    public void ShowMenu()
    {
        Console.WriteLine("1. Employee");
        Console.WriteLine("2. Inventory");
        Console.WriteLine("3. Billing");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ERPSystem erp = new ERPSystem();
        erp.ShowMenu();
    }
}
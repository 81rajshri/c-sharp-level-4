using System;
using System.Collections.Generic;

class Product
{
    public int Id;
    public string Name;
    public int Quantity;
}

class Program
{
    static List<Product> products = new List<Product>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1. Add Product\n2. Update Stock\n3. Display Inventory\n4. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    UpdateStock();
                    break;
                case 3:
                    DisplayProducts();
                    break;
            }

        } while (choice != 4);
    }

    static void AddProduct()
    {
        Product p = new Product();

        Console.Write("Enter Product ID: ");
        p.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        p.Name = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        p.Quantity = int.Parse(Console.ReadLine());

        products.Add(p);
    }

    static void UpdateStock()
    {
        Console.Write("Enter Product ID: ");
        int id = int.Parse(Console.ReadLine());

        foreach (var p in products)
        {
            if (p.Id == id)
            {
                Console.Write("Enter new quantity: ");
                p.Quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Stock Updated");
                return;
            }
        }
        Console.WriteLine("Product not found");
    }

    static void DisplayProducts()
    {
        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Qty: {p.Quantity}");
        }
    }
}
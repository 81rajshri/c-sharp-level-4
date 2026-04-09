using System;
using System.Collections.Generic;

class Book
{
    public int Id;
    public string Title;
    public bool IsIssued;
}

class Program
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1. Add Book\n2. Issue Book\n3. Display Books\n4. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    IssueBook();
                    break;
                case 3:
                    DisplayBooks();
                    break;
            }
        } while (choice != 4);
    }

    static void AddBook()
    {
        Book b = new Book();

        Console.Write("Enter Book Id: ");
        b.Id = int.Parse(Console.ReadLine());

        Console.Write("Enter Title: ");
        b.Title = Console.ReadLine();

        b.IsIssued = false;
        books.Add(b);
    }

    static void IssueBook()
    {
        Console.Write("Enter Book Id to issue: ");
        int id = int.Parse(Console.ReadLine());

        foreach (var b in books)
        {
            if (b.Id == id && !b.IsIssued)
            {
                b.IsIssued = true;
                Console.WriteLine("Book Issued");
                return;
            }
        }
        Console.WriteLine("Book not available");
    }

    static void DisplayBooks()
    {
        foreach (var b in books)
        {
            Console.WriteLine($"Id: {b.Id}, Title: {b.Title}, Issued: {b.IsIssued}");
        }
    }
}
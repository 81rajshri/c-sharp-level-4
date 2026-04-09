using System;
using System.IO;

class Program
{
    static string path = "data.txt";

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1. Add\n2. View\n3. Delete All\n4. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddData();
                    break;
                case 2:
                    ViewData();
                    break;
                case 3:
                    DeleteData();
                    break;
            }

        } while (choice != 4);
    }

    static void AddData()
    {
        Console.Write("Enter text: ");
        string data = Console.ReadLine();

        File.AppendAllText(path, data + Environment.NewLine);
    }

    static void ViewData()
    {
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine("\nFile Content:\n" + content);
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }

    static void DeleteData()
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("File Deleted");
        }
    }
}
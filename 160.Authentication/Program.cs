using System;
using System.Collections.Generic;

class User
{
    public string Username;
    public string Password;
    public string Role;
}

class Program
{
    static List<User> users = new List<User>()
    {
        new User { Username="admin", Password="123", Role="Admin" },
        new User { Username="user", Password="123", Role="User" }
    };

    static void Main()
    {
        Console.Write("Enter Username: ");
        string uname = Console.ReadLine();

        Console.Write("Enter Password: ");
        string pass = Console.ReadLine();

        var user = users.Find(u => u.Username == uname && u.Password == pass);

        if (user != null)
        {
            Console.WriteLine("Login Successful!");

            if (user.Role == "Admin")
            {
                Console.WriteLine("Welcome Admin! You can manage system.");
            }
            else
            {
                Console.WriteLine("Welcome User! Limited access.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Login!");
        }
    }
}
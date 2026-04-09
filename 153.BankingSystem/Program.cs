using System;

class Account
{
    public double Balance = 1000;

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Deposited Successfully");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdraw Successful");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine("Balance: " + Balance);
    }
}

class Program
{
    static void Main()
    {
        Account acc = new Account();
        int choice;

        do
        {
            Console.WriteLine("\n1. Deposit\n2. Withdraw\n3. Check Balance\n4. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount: ");
                    acc.Deposit(double.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.Write("Enter amount: ");
                    acc.Withdraw(double.Parse(Console.ReadLine()));
                    break;
                case 3:
                    acc.ShowBalance();
                    break;
            }
        } while (choice != 4);
    }
}
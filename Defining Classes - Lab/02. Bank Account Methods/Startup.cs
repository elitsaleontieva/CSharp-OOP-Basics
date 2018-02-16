using System;


   public class Program
    {
        static void Main(string[] args)
        {
        BankAccount acc = new BankAccount();

        acc.Deposit(15);
        acc.Withdraw(10);

        Console.WriteLine(acc);

        
        }
    }



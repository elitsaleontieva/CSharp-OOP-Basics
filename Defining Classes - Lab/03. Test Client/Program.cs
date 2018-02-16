using System;
using System.Collections.Generic;
using System.Linq;

   public class Program
    {
        static void Main(string[] args)
        {
        var dictionary = new Dictionary<int, BankAccount>();

        var input = Console.ReadLine();

        while (input!="End")
        {
            var chars = " ".ToArray();
            var parts = input.Split(chars, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var command = parts[0];
            var accountId = int.Parse(parts[1]);

            decimal amount=0;
            if (parts.Length==3)
            {
                amount = decimal.Parse(parts[2]);
            }

            switch (command)
            {
                case "Create":
                   
                        if (dictionary.ContainsKey(accountId))
                        {
                            Console.WriteLine("Account already exists");
                        }
                        else
                        {
                            BankAccount bankAccount = new BankAccount(accountId);
                            dictionary[accountId] = bankAccount;
                        dictionary[accountId].Id = accountId;
                        }
                    
                    break;

                case "Deposit":
                    if (!dictionary.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        dictionary[accountId].Deposit(amount);
                    }
                    break;

                case "Withdraw":
                    if (!dictionary.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account does not exist");

                    }
                    else if (dictionary.ContainsKey(accountId) && dictionary[accountId].Balance < amount)
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    
                    else if(dictionary.ContainsKey(accountId) && dictionary[accountId].Id==accountId)
                    {

                        dictionary[accountId].Withdraw(amount);
                    }
                 
                    break;

                case "Print":

                    if (!dictionary.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        Console.WriteLine($"{dictionary[accountId].ToString()}");
                    }

                    break;
            }
            input = Console.ReadLine();
        }
       



        
        }
  
}



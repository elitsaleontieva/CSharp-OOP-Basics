using System;
using System.Collections.Generic;
using System.Text;


public class BankAccount
{

    public int Id { get; set; }
    public decimal Balance { get; set; }

//    •	Deposit(decimal amount): void
//•	Withdraw(decimal amount): void

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account {this.Id}, balance {this.Balance}";
    }
}



using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Scriptures scriptures = new Scriptures();
        scriptures.DisplayScriptures();
    }
}

public class BankAccount
{
    private string accountNumber;
    private decimal balance;
    private string owner;

    public BankAccount(string accountNumber, decimal initialBalance, string owner)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
        this.owner = owner;
    }

    public void Deposit(decimal amount)
    {
        // Perform validation checks and update the balance
        // ...
    }

    public void Withdraw(decimal amount)
    {
        // Perform validation checks and update the balance
        // ...
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

using System;
class Bank
{
    private int balance{get;set;}

    public void Deposit(int balance)
    {
        this.balance = balance;
    }
    
      public void Withdraw(int value)
    {
        balance -= value;
    } 

    public void Show()
    {
        Console.WriteLine($"Actual balance is: {balance}");
    } 
    
}


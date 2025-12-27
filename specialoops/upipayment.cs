using System;

class UpiPayment : Payment
{
     public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using UPI");
    }


    public void Refund(double amount)
    {
        Console.WriteLine($"Refund ₹{amount} using UPI");
    }

}
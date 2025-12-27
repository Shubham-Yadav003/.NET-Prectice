using System;

class CreditCardPayment : Payment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid ₹{amount} using Credit Card");
    }


    public void Refund(double amount)
    {
        Console.WriteLine($"Refund ₹{amount} using Credit Card");
    }
}


// internal interface Payment
// {
//     void Pay(double amount);

//     void Refund(double amount);
// }
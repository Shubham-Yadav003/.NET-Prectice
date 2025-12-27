using System;

interface Payment
{
    void Pay(double amount);

    void Refund(double amount);
}
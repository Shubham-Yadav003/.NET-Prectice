using System;
// namespace PartialDemo;
namespace CalculatorApp
{
    // delegate decleration !
    public delegate int CalculatorDelegate(int num1, int num2);
    class Program
    {

        public static void Main()
        {
            // Payment pay = new CreditCardPayment();
            // pay.Refund(100.0);
            // pay.Pay(1000.0);


            //  PartialDemo part = new PartialDemo();
            //  part.FirstName  = "shubham";
            //  part.LastName = "yadav";
            //  part.DisplayFullName();
            //  part.PartialMethod();

            Calculator obj = new Calculator(); // objected created 

            CalculatorDelegate calcAdd = new CalculatorDelegate(obj.Add); // using delegate for reference 

            CalculatorDelegate calcSub = new CalculatorDelegate(obj.Sub);

            CalculatorDelegate calcMul = new CalculatorDelegate(obj.Mul);

            CalculatorDelegate calcDiv = new CalculatorDelegate(obj.Div);


            // calling delegate
            // int sum = calcAdd(30, 20);
            // Console.WriteLine($"Addition: {sum}");

            // int sub = calcSub(30, 20);
            // Console.WriteLine($"Addition: {sub}");

            // int mul = calcMul(30, 20);
            // Console.WriteLine($"Addition: {mul}");

            // int div = calcDiv(30, 20);
            // Console.WriteLine($"Addition: {div}");

            CalculatorDelegate calcMulti;
            calcMulti = obj.Add;
            calcMulti += obj.Sub;
            calcMulti += obj.Mul;
            calcMulti += obj.Div;

            Console.WriteLine(calcMulti(30, 20));

        }
    }

}
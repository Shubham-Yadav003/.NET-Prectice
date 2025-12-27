using System;

namespace CalculatorApp
{
    public class Calculator()
    {
        int num1 =0;
        int num2=0;
        int result =0;

        public int Add(int num1, int num2) // return type and parameter same for delegate
        {
            return num1+num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1-num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1*num2;
        }

        public int Div(int num1, int num2)
        {
            return num1/num2;
        }

    }
}
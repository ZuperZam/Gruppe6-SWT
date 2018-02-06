using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Divide(double dividend, double divisor)
        {
            double result = 0;


            if (divisor == 0)
            {
                result = -1;
                throw new System.DivideByZeroException();

            }
                
            result = dividend / divisor;
            return result;
        }
    }
}

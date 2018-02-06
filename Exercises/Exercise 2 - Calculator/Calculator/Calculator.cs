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
            try
            {
                if (divisor != 0)
                    result = dividend / divisor;
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR: CAN'T DIVIDE BY ZERO");
                return -1;
            }

            return result;
        }
    }
}

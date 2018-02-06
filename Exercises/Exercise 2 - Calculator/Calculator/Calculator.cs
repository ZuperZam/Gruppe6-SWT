using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double addend)
        {
            Accumulator = addend + Accumulator;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Subtract(double subtractor)
        {
            Accumulator = subtractor - Accumulator;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Multiply(double multiplier)
        {
            return multiplier * Accumulator;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Power(double exponent)
        {
            return Math.Pow(Accumulator, exponent);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new System.DivideByZeroException();
                
            return dividend / divisor;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
                throw new System.DivideByZeroException();

            return Accumulator / divisor;
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}

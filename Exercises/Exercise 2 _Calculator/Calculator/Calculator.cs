using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double addend)
        {
            Accumulator = addend + Accumulator;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator = subtractor - Accumulator;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator = multiplier * Accumulator;
            return Accumulator;
        }

        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new System.DivideByZeroException();

<<<<<<< HEAD:Exercises/Exercise 2 _Calculator/Calculator/Calculator.cs
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
=======
            Accumulator = dividend / divisor;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
                throw new System.DivideByZeroException();

            Accumulator = Accumulator / divisor;
            return Accumulator;
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
>>>>>>> ff4f235f83d4c218b6cf484b87e6f1bb0a2afbf7:Exercises/Exercise 2 - Calculator/Calculator/Calculator.cs
        }
    }
}

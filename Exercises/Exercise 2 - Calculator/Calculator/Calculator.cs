﻿using System;

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
            return addend + Accumulator;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Subtract(double subtractor)
        {
            return subtractor - Accumulator;
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

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}

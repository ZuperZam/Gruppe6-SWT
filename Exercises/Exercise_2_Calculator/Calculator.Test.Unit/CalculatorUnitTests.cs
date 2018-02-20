using System;
using System.Configuration;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Troels Jensen")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 6)]
        [TestCase(-3, 0)]
        public void Add_PosAndNegNumbers_Accumulator(int addend, int result)
        {
            _uut.Add(2, 1);
            Assert.That(_uut.Add(addend), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(10, 4)]
        [TestCase(-3, -9)]
        public void Subtract_SubtractPosAndNegNumbers_Accumulator(int a, int result)
        {
            _uut.Subtract(4, -2);
            Assert.That(_uut.Subtract(a), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 18)]
        [TestCase(-3, -18)]
        public void Multiply_MultiplyNumbers_Accumulator(int a, int result)
        {
            _uut.Multiply(2, 3);
            Assert.That(_uut.Multiply(a), Is.EqualTo(result));
        }

        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(2, 16)]
        [TestCase(-1, 0.25)]
        public void Power_RaiseNumbers_Accumulator(double x, double result)
        {
            _uut.Power(2, 2);
            Assert.That(_uut.Power(x), Is.EqualTo(result));
        }

        [TestCase(2, 0)]
        public void Divide_ByZero_Exception(double divider, double dividend)
        {
            Assert.Throws<DivideByZeroException>(() => _uut.Divide(divider, dividend));
        }

        [TestCase(2, 2)]
        public void Divide_NoException(double divider, double dividend)
        {
            Assert.DoesNotThrow(() => _uut.Divide(divider, dividend));
        }

        [TestCase(3, 2, 1.5)]
        [TestCase(-3, -2, 1.5)]
        [TestCase(-3, 2, -1.5)]
        [TestCase(3, -2, -1.5)]
        [TestCase(0.5, -2.5, -0.2)]
        [TestCase(-2.5, 0.5, -5)]
        public void Divide_ByNumber(double divider, double dividend, double result)
        {
            Assert.That(_uut.Divide(divider, dividend), Is.EqualTo(result));

        }

        [TestCase(2, 1)]
        [TestCase(-2, -1)]
        public void Divide_ByNumber_Accumulator(double divider, double result)
        {
            _uut.Divide(8, 4);
            Assert.That(_uut.Divide(divider), Is.EqualTo(result));
        }

        [TestCase(0)]
        public void Divide_ByZeroException_Accumulator(double divider)
        {
            _uut.Divide(8, 4);
            Assert.Throws<DivideByZeroException>(() => _uut.Divide(divider));
        }

        [TestCase(2)]
        public void Divide_NoByZeroException_Accumulator(double divider)
        {
            _uut.Divide(8, 4);
            Assert.DoesNotThrow(() => _uut.Divide(divider));
        }

        [TestCase(2, 0)]
        public void Power_ByNumber_PosAndNeg(double exponent, double result)
        {
            Assert.That(_uut.Power(exponent), Is.EqualTo(result));
        }

        [TestCase(0)]
        public void Clear_Accumulator(double result)
        {
            _uut.Add(1, 1);
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }
    }

}

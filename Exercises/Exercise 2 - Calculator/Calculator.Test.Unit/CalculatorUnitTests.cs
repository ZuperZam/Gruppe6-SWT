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


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
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

        [TestCase(2, 0)]
        public void Power_ByNumber_PosAndNeg(double exponent, double result)
        {
            Assert.That(_uut.Power(exponent), Is.EqualTo(result));
        }

        public void Accumulator_Set(double result)
        {
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }
        [TestCase(0)]
        public void Clear_Accumulator(double result)
        {
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }
    }

}

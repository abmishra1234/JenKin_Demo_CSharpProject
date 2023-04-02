using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace CalculatorAppTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            Calculator calculator = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(6, 0));
        }
    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        [TestMethod()]
        public void SumTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(Calculator.Sum(2, 4) == 6);
        }

        [TestMethod()]
        public void SubstractionTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(Calculator.Substraction(4, 2) == 2);
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(Calculator.Multiplication(2, 4) == 8);
        }

        [TestMethod()]
        public void DivisionTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(Calculator.Division(4, 4) == 1);
        }
    }
}
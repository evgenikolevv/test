using Microsoft.VisualStudio.TestTools.UnitTesting;
using zadachaUnitTests1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachaUnitTests1.Tests
{
    [TestClass()]
    public class EquationTests
    {
        [TestMethod()]
        public void calculateTest()
        {
            Equation equation = new Equation();
            Assert.AreEqual("Two Imaginary Solutions:   0.0000 +   0.8660 i or   0.0000 +   0.8660 i", equation.calculate(2,2,2));
            Assert.AreNotEqual("Two Imaginary Solutions:   0.0000 +   0.8660 i or   0.0000 +   0.8660 i", equation.calculate(3, 2, 2));
        }
    }
}
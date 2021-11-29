using Microsoft.VisualStudio.TestTools.UnitTesting;
using zadacha2UnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2UnitTests.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void validateUsernameTest()
        {
            Validation validation = new Validation();

            Assert.IsTrue(validation.validateUsername("tests98"));
        }

        [TestMethod()]
        public void validatePasswordTest()
        {
            Validation validation = new Validation();

            Assert.IsTrue(validation.validatePassword("pas?"));
        }
    }
}
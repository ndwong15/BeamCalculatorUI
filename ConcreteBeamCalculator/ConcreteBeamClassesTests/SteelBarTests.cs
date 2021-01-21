using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConcreteBeamClasses;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConcreteBeamClasses.Tests
{
    [TestClass()]
    public class SteelBarTests
    {
        [TestMethod()]
        public void SteelBarConstructorTest()
        {
            SteelBar actual = new SteelBar(10, 100);

            Assert.AreEqual(actual.Area, 100);
            Assert.AreEqual(actual.Identifier, 10);
            Assert.AreEqual(actual.Quantity, 0);
        }

        [TestMethod()]
        public void SteelBarQuantityConstructorTest()
        {
            SteelBar actual = new SteelBar(10, 100, 2);

            Assert.AreEqual(100, actual.Area);
            Assert.AreEqual(10, actual.Identifier);
            Assert.AreEqual(2, actual.Quantity);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void SteelBarConstructorNegativeNumberTest()
        {
            SteelBar actual = new SteelBar(10, -100);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void SteelBarConstructorAreaZeroTest()
        {
            SteelBar actual = new SteelBar(10, 0);
        }

        [TestMethod()]
        public void GetTotalBarAreaTest()
        {
            SteelBar test = new SteelBar(10, 100, 2);
            double expected = 200;
            double actual = test.GetTotalBarArea();

            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConcreteBeamClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcreteBeamClasses.Tests
{
    [TestClass()]
    public class SteelAreaTests
    {
        [TestMethod()]
        public void SteelAreaConstructorTest()
        {
            SteelArea actual = new SteelArea();

            Assert.AreEqual(0, actual[55].Quantity);
            Assert.AreEqual(0, actual[15].Quantity);
        }

        [TestMethod()]
        public void SteelAreaConstructorArrayTest()
        {
            int[] quantity = { 2, 1, 0, 0, 0, 0, 0, 0 };
            SteelArea actual = new SteelArea(quantity);

            Assert.AreEqual(2, actual[10].Quantity);
        }

        [TestMethod()]
        public void GetTotalAreaTest()
        {
            int[] quantity = { 2, 1, 0, 0, 0, 0, 0, 0};
            SteelArea test = new SteelArea(quantity);

            double actual = test.GetTotalArea();
            double expected = 400;

            Assert.AreEqual( expected, actual, 0.01);
        }

        [TestMethod()]
        public void IndexerTest()
        {
            int[] quantity = { 2, 1, 0, 0, 0, 0, 0, 0 };
            SteelArea actual = new SteelArea(quantity);

            Assert.AreEqual(2, actual[10].Quantity);
        }
    }
}
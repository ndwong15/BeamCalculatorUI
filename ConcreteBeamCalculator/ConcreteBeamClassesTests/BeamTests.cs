using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConcreteBeamClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcreteBeamClasses.Tests
{
    [TestClass()]
    public class BeamTests
    {
        [TestMethod()]
        public void GetMomentResistanceTest()
        {
            int[] quantity = { 2, 0, 0, 0, 0, 0, 0, 0 };
            Beam actual = new Beam();
            actual.AreaOfSteel.SetBarQuantities(quantity);
            actual.SteelStrength = 400;
            actual.ConcreteStrength = 45;
            actual.Depth = 400;
            actual.Width = 200;
            actual.SteelMaterialFactor = 0.85;
            actual.ConcreteMeterialFactor = 0.65;

            double expectedStrength = 23634934.6;
            Assert.AreEqual(expectedStrength, actual.GetMomentResistance(), 0.1);
        }

        [TestMethod()]
        public void Alpha1Test()
        {
            Beam actual = new Beam();
            actual.SteelStrength = 400;
            actual.ConcreteStrength = 45;

            double expected = 0.7825;
            Assert.AreEqual(expected, actual.ReturnAlpha1(), 0.001);
        }

        [TestMethod()]
        public void Beta1Test()
        {
            Beam actual = new Beam();
            actual.SteelStrength = 400;
            actual.ConcreteStrength = 45;

            double expected = 0.8575;
            Assert.AreEqual(expected, actual.ReturnBeta1(), 0.001);
        }
    }
}
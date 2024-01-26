using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery;

namespace PierreBakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForMultipleOfThree()
        {
            Pastry pastry = new Pastry(6);
            Assert.AreEqual(10, pastry.CalculateCost());
        }

        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForNotMultipleOfThree()
        {
            Pastry pastry = new Pastry(5);
            Assert.AreEqual(8, pastry.CalculateCost());
        }

        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForZeroQuantity()
        {
            Pastry pastry = new Pastry(0);
            Assert.AreEqual(0, pastry.CalculateCost());
        }
    }
}
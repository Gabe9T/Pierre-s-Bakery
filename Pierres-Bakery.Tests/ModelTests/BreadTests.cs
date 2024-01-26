using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery;

namespace PierreBakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForMultipleOfThree()
        {
            Bread bread = new Bread(6);
            Assert.AreEqual(20, bread.CalculateCost());
        }

        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForNotMultipleOfThree()
        {
            Bread bread = new Bread(5);
            Assert.AreEqual(20, bread.CalculateCost());
        }

        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForZeroQuantity()
        {
            Bread bread = new Bread(0);
            Assert.AreEqual(0, bread.CalculateCost());
        }
    }
}
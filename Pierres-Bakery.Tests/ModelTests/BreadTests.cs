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
            Bread bread = new Bread();

            // a multiple of 3
            int totalCost1 = bread.CalculateCost(6);
            Assert.AreEqual(20, totalCost1);
        }

        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForNotMultipleOfThree()
        {
            Bread bread = new Bread();

            // not a multiple of 3
            int totalCost2 = bread.CalculateCost(5);
            Assert.AreEqual(20, totalCost2);
        }

        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForZeroQuantity()
        {
            Bread bread = new Bread();

            // 0 quantity
            int totalCost3 = bread.CalculateCost(0);
            Assert.AreEqual(0, totalCost3);
        }
    }
}
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
            Pastry pastry = new Pastry();

            // a multiple of 3
            int totalCost1 = pastry.CalculateCost(6);
            Assert.AreEqual(10, totalCost1); 
        }

        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForNotMultipleOfThree()
        {
            Pastry pastry = new Pastry();

            // not a multiple of 3
            int totalCost2 = pastry.CalculateCost(5);
            Assert.AreEqual(8, totalCost2);
        }

        [TestMethod]
        public void CalculateCost_ReturnsCorrectTotalCost_ForZeroQuantity()
        {
            Pastry pastry = new Pastry();

            // 0 quantity
            int totalCost3 = pastry.CalculateCost(0);
            Assert.AreEqual(0, totalCost3);
        }
    }
}
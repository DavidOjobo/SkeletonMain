using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock StockManagement = new clsStock();
            Assert.IsNotNull(StockManagement);
        }
        [TestMethod]
        public void ProductNoPropertyOK()
        {
            clsStock StockManagement = new clsStock();
            String TestData = "2a";
            StockManagement.ProductNo = TestData;
            Assert.AreEqual(StockManagement.ProductNo, TestData);
        }
        [TestMethod]
        public void QuantityOrderedPropertyOK()
        {
            clsStock StockManagement = new clsStock();
            Int32 TestData = 1;
            StockManagement.QuantityOrdered = TestData;
            Assert.AreEqual(StockManagement.QuantityOrdered, TestData);
        }
        [TestMethod]
        public void ProductDescriptionPropertyOK()
        {
            clsStock StockManagement = new clsStock();
            String TestData = "a b c";
            StockManagement.ProductDescription = TestData;
            Assert.AreEqual(StockManagement.ProductDescription, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock StockManagement = new clsStock();
            Double TestData = 1.00;
            StockManagement.Price = TestData;
            Assert.AreEqual(StockManagement.Price, TestData);

        }
        [TestMethod]
        public void DatePropertyOK()
        {
            clsStock StockManagement = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            StockManagement.Date = TestData;
            Assert.AreEqual(StockManagement.Date, TestData);
        }
        [TestMethod]
        public void QuantityInStockPropertyOK()
        {
            clsStock StockManagement = new clsStock();
            Int32 TestData = 1;
            StockManagement.QuantityInStock = TestData;
            Assert.AreEqual(StockManagement.QuantityInStock, TestData);
        }
    }
}

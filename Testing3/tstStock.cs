using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStock StockManagement = new clsStock();
            Assert.IsNotNull(StockManagment);
        }
        [TestMethod]
        public void ProductNoProperty()
        {
            clsStock StockManagement = new clsStock();
            String TestData = "1a";
            StockManagement.ProductNo = TestData;
            Assert.AreEqual(StockManagement.ProductNo, TestData);
        }
        [TestMethod]
        public void Name()
        {
            clsStock StockManagement = new clsStock();
            String TestData = "1b";
            StockManagement.Name = TestData;
            Assert.AreEqual(StockManagement.Name, TestData);

        }
        [TestMethod]
        public void ProductDescription()
        {
            clsStock StockManagement = new clsStock();
            String TestData = "1c";
            StockManagement.ProductDesc = TestData;
            Assert.AreEqual(StockManagement.ProductDesc, TestData);

        }
        [TestMethod]
        public void Price()
        {
            clsStock StockManagement = new clsStock();
            Double TestData = 1.00;
            StockManagement.Price = TestData;
            Assert.AreEqual(StockManagement.Price, TestData);

        }
        [TestMethod]
        public void Date()
        {
            clsStock StockManagement = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            StockManagement.Date = TestData;
            Assert.AreEqual(StockManagement.Date, TestData);

        }
        [TestMethod]
        public void Dispatched()
        {
            clsStock StockManagement = new clsStock();
            Boolean TestData = true;
            StockManagement.Dispatched = TestData;
            Assert.AreEqual(StockManagement.Dispatched, TestData);

        }




    }
}

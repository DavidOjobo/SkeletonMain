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

            Assert.IsNotNull(StockManagement);

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

        public void QuantityOrdered()

        {

            clsStock StockManagement = new clsStock();

            String TestData = "1b";

            StockManagement.QuantityOrdered = TestData;

            Assert.AreEqual(StockManagement.QuantityOrdered, TestData);



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

        public void QuantityInStock()

        {

            clsStock StockManagement = new clsStock();

            String TestData = "1b";

            StockManagement.QuantityInStock = TestData;

            Assert.AreEqual(StockManagement.QuantityInStock, TestData);



        }










    }

}
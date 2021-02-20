using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrder OrderProcessing = new clsOrder();
            Assert.IsNotNull(OrderProcessing);
        }
        [TestMethod]
        public void ProductNoProperty()
        {
            clsOrder OrderProcessing = new clsOrder();
            String TestData = "1a";
            OrderProcessing.ProductNo =TestData;
            Assert.AreEqual(OrderProcessing.ProductNo, TestData);
        }
        [TestMethod]
        public void OrderNo()
        {
            clsOrder OrderProcessing = new clsOrder();
            Int32 TestData = 1;
            OrderProcessing.OrderNo = TestData;
            Assert.AreEqual(OrderProcessing.OrderNo, TestData);

        }
        [TestMethod]
        public void ProductDescription()
        {
            clsOrder OrderProcessing = new clsOrder();
            String TestData = "1b";
            OrderProcessing.ProductDesc = TestData;
            Assert.AreEqual(OrderProcessing.ProductDesc, TestData);

        }
        [TestMethod]
        public void Price()
        {
            clsOrder OrderProcessing = new clsOrder();
            Double TestData = 1.00;
            OrderProcessing.Price = TestData;
            Assert.AreEqual(OrderProcessing.Price, TestData);

        }
        [TestMethod]
        public void Date()
        {
            clsOrder OrderProcessing = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            OrderProcessing.Date = TestData;
            Assert.AreEqual(OrderProcessing.Date, TestData);

        }
        [TestMethod]
        public void Dispatched()
        {
            clsOrder OrderProcessing = new clsOrder();
            Boolean TestData = true;
            OrderProcessing.Dispatched = TestData;
            Assert.AreEqual(OrderProcessing.Dispatched, TestData);

        }




    }
}

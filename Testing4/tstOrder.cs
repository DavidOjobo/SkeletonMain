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
    }
}

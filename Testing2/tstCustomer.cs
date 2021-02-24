using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }
        [TestMethod]
        public void ProductNoOK()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "2a";
            Customer.ProductNo = TestData;
            Assert.AreEqual(Customer.ProductNo, TestData);
        }

    }
}

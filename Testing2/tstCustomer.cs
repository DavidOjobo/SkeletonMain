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

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCustomer Customer = new clsCustomer();
            Int32 TestData = 2;
            Customer.CustomerID = TestData;
            Assert.AreEqual(Customer.CustomerID, TestData);
        }

        [TestMethod]
        public void FullNameOK()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "2a";
            Customer.FullName = TestData;
            Assert.AreEqual(Customer.FullName, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "2a";
            Customer.Email = TestData;
            Assert.AreEqual(Customer.Email, TestData);
        }

        [TestMethod]
        public void OrderNo()
        {
            clsCustomer Customer = new clsCustomer();
            Int32 TestData = 1;
            Customer.OrderNo = TestData;
            Assert.AreEqual(Customer.OrderNo, TestData);
        }

        [TestMethod]
        public void PhoneNumber()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "2a";
            Customer.PhoneNumber = TestData;
            Assert.AreEqual(Customer.PhoneNumber, TestData);
        }
        [TestMethod]
        public void Address()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "2a";
            Customer.Address = TestData;
            Assert.AreEqual(Customer.Address, TestData);
        }
        [TestMethod]
        public void DateOK()
        {
            clsCustomer Customer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            Customer.Date = TestData;
            Assert.AreEqual(Customer.Date, TestData);
        }
    }
}

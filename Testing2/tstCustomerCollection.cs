using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            //TestItem.Active = true;
            TestItem.ProductNo = 1;
            TestItem.PhoneNumber = 1;
            TestItem.FullName = "Bob Smith";
            TestItem.Email = "Jsaosfij@ishfs.com";
            TestItem.CustomerID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "9 Hamilton Road LE5 J3D";
            TestItem.OrderNo = 1;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);


        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Int32 SomeCount = 0;
            AllCustomers.Count = SomeCount;
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            //TestItem.Active = true;
            TestCustomer.ProductNo = 1;
            TestCustomer.PhoneNumber = 1;
            TestCustomer.FullName = "Bob Smith";
            TestCustomer.Email = "Jsaosfij@ishfs.com";
            TestCustomer.CustomerID = 1;
            TestCustomer.Date = DateTime.Now.Date;
            TestCustomer.Address = "9 Hamilton Road LE5 J3D";
            TestCustomer.OrderNo = 1;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            //TestItem.Active = true;
            TestItem.ProductNo = 1;
            TestItem.PhoneNumber = 1;
            TestItem.FullName = "Bob Smith";
            TestItem.Email = "Jsaosfij@ishfs.com";
            TestItem.CustomerID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "9 Hamilton Road LE5 J3D";
            TestItem.OrderNo = 1;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
}

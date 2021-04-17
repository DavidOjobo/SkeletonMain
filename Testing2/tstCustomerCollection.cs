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
            TestItem.PhoneNumber = "0000000000001";
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
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            //TestItem.Active = true;
            TestCustomer.ProductNo = 1;
            TestCustomer.PhoneNumber = "000000000001";
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
            TestItem.PhoneNumber = "0777777777777";
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

        [TestMethod]

        public void AddMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            //TestItem.Active = true;
            TestItem.ProductNo = 1;
            TestItem.PhoneNumber = "100000000000";
            TestItem.FullName = "Bob Smith";
            TestItem.Email = "Jsaosfij@ishfs.com";
            TestItem.CustomerID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "9 Hamilton Road LE5 J3D";
            TestItem.OrderNo = 1;
            Int32 PrimaryKey = 1;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.ProductNo = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]

        public void UpdateMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 1;
            //TestItem.Active = true;
           
            TestItem.PhoneNumber = "100000000000";
            TestItem.FullName = "Bob Smith";
            TestItem.Email = "Jsaosfij@ishfs.com";
            TestItem.CustomerID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "9 Hamilton Road LE5 J3D";
            TestItem.OrderNo = 1;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.ProductNo = PrimaryKey;
            //modify test data
            TestItem.PhoneNumber = "999999999999";
            TestItem.FullName = "John Smith";
            TestItem.Email = "Bobby@ishfs.com";
            TestItem.CustomerID = 3;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "90 Hamilton Road LE5 J3D";
            TestItem.OrderNo = 6;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        public void DeleteMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            //TestItem.Active = true;
            TestItem.ProductNo = 1;
            TestItem.PhoneNumber = "100000000000";
            TestItem.FullName = "Bob Smith";
            TestItem.Email = "Jsaosfij@ishfs.com";
            TestItem.CustomerID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "9 Hamilton Road LE5 J3D";
            TestItem.OrderNo = 1;
            Int32 PrimaryKey = 1;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.ProductNo = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

    }
}

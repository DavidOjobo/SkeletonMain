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
            TestItem.FullName = "Customer List";
            TestItem.Email = "CustomerList@gmail.com";
            TestItem.CustomerID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "9 Hamilton Road";
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
            TestCustomer.Email = "JasonBourne@bad.com";
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
            TestItem.PhoneNumber = "71471471471";
            TestItem.FullName = "List Count";
            TestItem.Email = "ListCount@gmail.com";
            TestItem.CustomerID = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "714 List Avenue";
            //TestItem.OrderNo = 1;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]

        public void AddMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            
            TestItem.CustomerID = 64;
            //TestItem.ProductNo = 23;
            TestItem.PhoneNumber = "100000000000";
            TestItem.FullName = "Bob Smith";
            TestItem.Email = "JackTim@Lonely.com";    
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "6 Cool Road";
            TestItem.PostCode = "LE1 9NS";
            TestItem.Active = true;
            Int32 PrimaryKey = 1;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]

        public void UpdateMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 1;
            TestItem.Active = true;
            TestItem.PhoneNumber = "66666666666";
            TestItem.FullName = "Update Method";
            TestItem.Email = "UpdateMethod@gmail.com";
            TestItem.CustomerID = 65;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "9 Update Road";
            TestItem.PostCode = "LE6 6UM";
            
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            //modify test data
            TestItem.PhoneNumber = "999999999999";
            TestItem.FullName = "Done Update";
            TestItem.Email = "DoneUpdate@gmail.com";
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "60 Updated Street";
            TestItem.PostCode = "LE6 9UM";  
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            //TestItem.ProductNo = 25;
            TestItem.PhoneNumber = "100000000000";
            TestItem.FullName = "Delete Me";
            TestItem.Email = "Delete@Delete.com";
            TestItem.Date = DateTime.Now.Date;
            TestItem.Address = "9 Delete Road LE5 J3D";
            TestItem.PostCode = "LE9 7UJ";
            Int32 PrimaryKey = 1;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]

        public void ReportByFullNameOK()
        {
            //filters the record using the Full Name

            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFullName("XXX XXX");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByFullName("XXX XXX");
            if (FilteredCustomers.Count == 2)
            {
               if (FilteredCustomers.CustomerList[1].CustomerID != 2)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[2].CustomerID != 3)
                {
                    OK = false;

                }
                else
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }
        }
    }
}

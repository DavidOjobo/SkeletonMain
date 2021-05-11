using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Testing2
{
    [TestClass]
    public class clsOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Dispatched = true;
            TestItem.ProductName = "kenny";
            TestItem.ProductNo = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Price = 84.0000;
            TestItem.OrderNo = 1;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);


        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            ClassLibrary.clsOrdersCollection AllOrders = new ClassLibrary.clsOrdersCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Dispatched = true;
            TestOrder.ProductName = "kenny";
            TestOrder.ProductNo = 1;
            TestOrder.Date = DateTime.Now.Date;
            TestOrder.Price = 84.0000;
            TestOrder.OrderNo = 1;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            ClassLibrary.clsOrdersCollection AllOrders = new ClassLibrary.clsOrdersCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Dispatched = true;
            TestItem.ProductName = "kenny";
            TestItem.ProductNo = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Price = 84.0000;
            TestItem.OrderNo = 1;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsOrdersCollection AllOrders = new ClassLibrary.clsOrdersCollection();
            Assert.AreEqual(AllOrders.Count, 2);

        }
        [TestMethod]
        public void AddMethodOk()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrder TestItem = new clsOrder();
            Int32 Primarykey = 0;
            TestItem.Dispatched = true;
            TestItem.ProductName = "kenny";
            TestItem.ProductNo = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Price = 84.0000;
            TestItem.OrderNo = 1;

            AllOrders.ThisOrder = TestItem;
            Primarykey = AllOrders.Add();
            TestItem.OrderNo = Primarykey;
            AllOrders.ThisOrder.Find(Primarykey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]

        public void UpdateMethodOK()
        {

            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 1;
            TestItem.Dispatched = true;
            TestItem.ProductName = "kenny";
            TestItem.ProductNo = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Price = 84.0000;
            TestItem.OrderNo = 1;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.ProductNo = PrimaryKey;
            //modify test data
            TestItem.Dispatched = true;
            TestItem.ProductName = "kenny";
            TestItem.ProductNo = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Price = 84.0000;
            TestItem.OrderNo = 1;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Dispatched = true;
            TestItem.ProductName = "kenny";
            TestItem.ProductNo = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Price = 84.0000;
            TestItem.OrderNo = 1;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
           
        [TestMethod]
        public void ReportByProductNameOK()
        {
            //clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            FilteredOrders.ReportByProductNameOK("XXX XXX");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByProductnameTestDataFound()
        {
            clsOrdersCollection FilteredOrders = new clsOrdersCollection
            Boolean OK = true;
            FilteredOrdersOrders.ReportByProductName("yyy yyy");
            if (FilteredOrders.CountOK == 2)
            {
                if (FilteredOrders.OrderListOK[0].OrderNo != 36)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}




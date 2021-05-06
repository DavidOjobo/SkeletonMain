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
            ClassLibrary.clsOrderCollection AllOrders = new ClassLibrary.clsOrderCollection();
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
            ClassLibrary.clsOrderCollection AllOrders = new ClassLibrary.clsOrderCollection();
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
            ClassLibrary.clsOrderCollection AllOrders = new ClassLibrary.clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);

        }
        


        }

    }



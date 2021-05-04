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
            Int32 TestData = 1;
            OrderProcessing.ProductNo = TestData;
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
        [TestMethod]
        public void ProductName()
        {
            clsOrder OrderProcessing = new clsOrder();
            string TestData = "text";
            OrderProcessing.ProductName = TestData;
            Assert.AreEqual(OrderProcessing.ProductName, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder OrderProcessing = new clsOrder();
            Boolean Found = false;
            Int32 ProductNo = 1;
            Found = OrderProcessing.Find(ProductNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductNoFound()
        {
            // create an instance of the class we want to create
            clsOrder OrderProcessing = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = OrderProcessing.Find(ProductNo);
            //check the address no
            if (OrderProcessing.ProductNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductNameFound()
        {
            // create an instance of the class we want to create
            clsOrder OrderProcessing = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = OrderProcessing.Find(ProductNo);
            //check the address no
            if (OrderProcessing.ProductName != "kenny")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            // create an instance of the class we want to create
            clsOrder OrderProcessing = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = OrderProcessing.Find(ProductNo);
            //check the address no
            if (OrderProcessing.OrderNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            // create an instance of the class we want to create
            clsOrder OrderProcessing = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = OrderProcessing.Find(ProductNo);
            //check the address no
            if (OrderProcessing.Price != 84.00)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateFound()
        {
            // create an instance of the class we want to create
            clsOrder OrderProcessing = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = OrderProcessing.Find(ProductNo);
            //check the address no
            if (OrderProcessing.Date != Convert.ToDateTime("01/01/21"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDispatchedFound()
        {
            // create an instance of the class we want to create
            clsOrder OrderProcessing = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = OrderProcessing.Find(ProductNo);
            //check the address no
            if (OrderProcessing.Dispatched != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}

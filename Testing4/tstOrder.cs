using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        String ProductName = "kenny";
        Int32 OrderNo = 3;
        String Date = DateTime.Now.Date.ToString();
        Int32 ProductNo = 2;
        Double Price = 90.0000;

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
        public void OrderNoPropertyOK()
        {
            clsOrder OrderProcessing = new clsOrder();
            Int32 TestData = 1;
            OrderProcessing.OrderNo = TestData;
            Assert.AreEqual(OrderProcessing.OrderNo, TestData);

        }


        [TestMethod]
        public void PriceProperty()
        {
            clsOrder OrderProcessing = new clsOrder();
            Double TestData = 1.00;
            OrderProcessing.Price = TestData;
            Assert.AreEqual(OrderProcessing.Price, TestData);

        }
        [TestMethod]
        public void DateProperty()
        {
            clsOrder OrderProcessing = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            OrderProcessing.Date = TestData;
            Assert.AreEqual(OrderProcessing.Date, TestData);

        }
        [TestMethod]
        public void DispatchedProperty()
        {
            clsOrder OrderProcessing = new clsOrder();
            Boolean TestData = true;
            OrderProcessing.Dispatched = TestData;
            Assert.AreEqual(OrderProcessing.Dispatched, TestData);

        }
        [TestMethod]
        public void ProductNameProperty()
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


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance for the class Customer
            clsOrder Order = new clsOrder();
            //String variable to store the Error message
            String Error = "";
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void ProductNameLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaa"; //this should be ok
                                     //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        [TestMethod]

        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaaaa"; //this should be ok
                                       //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






        [TestMethod]

        public void ProductNameMax()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaaaa"; //this should be ok
                                       //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]

        public void ProductNameMid()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaa"; //this should be ok
                                     //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]

        public void ProductNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'a');
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }








        [TestMethod]
        public void DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }







        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string Date = "This is NOT a date";
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }







        [TestMethod]
        public void ProductNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            Int32 ProductNo = 0;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ProductNoMin()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            Int32 ProductNo = 1;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void ProductNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 ProductNo = 2;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 ProductNo = 49;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void ProductNoMax()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 ProductNo = 50;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void ProductNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 ProductNo = 50;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ProductNoMid()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 ProductNo = 25;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void OrderNoLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            Int32 OrderNo = 0;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void OrderNoMin()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 OrderNo = 1;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void OrderNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 OrderNo = 2;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void OrderNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 OrderNo = 49;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderNoMax()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 OrderNo = 50;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 OrderNo = 51;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void OrderNoMid()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 OrderNo = 25;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            Int32 Price = 0;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            Double Price = 84.00;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Double Price = 85.00;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Double Price = 97.00;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Double Price = 98.00;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Double Price = 99.00;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsOrder Order = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Double Price = 91.50;
            //invoke the method
            Error = Order.Valid(ProductName, ProductNo, OrderNo, Date, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }

}

using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        
            String ProductName = "Nike";
            String ProductNo = 1.ToString();
            String Price = 1.00.ToString();
            String Date = DateTime.Now.Date.ToString();
            String QuantityOrdered = 1.ToString();
            String QuantityInStock = 1.ToString();
        

            [TestMethod]
        public void InstanceOK()
        {
            clsStock StockManagement = new clsStock();
            Assert.IsNotNull(StockManagement);
        }
        [TestMethod]
        public void ProductNoPropertyOK()
        {
            clsStock StockManagement = new clsStock();
             Int32 TestData = 1;
            StockManagement.ProductNo = TestData;
            Assert.AreEqual(StockManagement.ProductNo, TestData);
        }
        [TestMethod]
        public void QuantityOrderedPropertyOK()
        {
            clsStock StockManagement = new clsStock();
            Int32 TestData = 2;
            StockManagement.QuantityOrdered = TestData;
            Assert.AreEqual(StockManagement.QuantityOrdered, TestData);
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsStock StockManagement = new clsStock();
            String TestData = "a b c";
            StockManagement.ProductName = TestData;
            Assert.AreEqual(StockManagement.ProductName, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock StockManagement = new clsStock();
            Double TestData = 1.00;
            StockManagement.Price = TestData;
            Assert.AreEqual(StockManagement.Price, TestData);

        }
        [TestMethod]
        public void DatePropertyOK()
        {
            clsStock StockManagement = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            StockManagement.Date = TestData;
            Assert.AreEqual(StockManagement.Date, TestData);
        }
        [TestMethod]
        public void QuantityInStockPropertyOK()
        {
            clsStock StockManagement = new clsStock();
            Int32 TestData = 1;
            StockManagement.QuantityInStock = TestData;
            Assert.AreEqual(StockManagement.QuantityInStock, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock StockManagement = new clsStock();
            Boolean Found = false;
            Int32 ProductNo = 1;
            Found = StockManagement.Find(ProductNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductNoFound()
        {
            // create an instance of the class we want to create
            clsStock StockManagement = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = StockManagement.Find(ProductNo);
            //Checks if the product number is correct
            if (StockManagement.ProductNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestProductNameFound()
        {
            // create an instance of the class we want to create
            clsStock StockManagement = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = StockManagement.Find(ProductNo);
            //checks if the product name is correct
            if (StockManagement.ProductName != "Nike")
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
            clsStock StockManagement = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = StockManagement.Find(ProductNo);
            //checks if the price is correct
            if (StockManagement.Price != 420.69)
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
            clsStock StockManagement = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = StockManagement.Find(ProductNo);
            //checks if the date is correct
            if (StockManagement.Date != Convert.ToDateTime("01/01/21"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityOrderedFound()
        {
            // create an instance of the class we want to create
            clsStock StockManagement = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = StockManagement.Find(ProductNo);
            //checks is quantityOrdered is correct
            if (StockManagement.QuantityOrdered != 1) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityInStockFound()
        {
            // create an instance of the class we want to create
            clsStock StockManagement = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method 
            Found = StockManagement.Find(ProductNo);
            //checks is quantityOrdered is correct
            if (StockManagement.QuantityInStock != 2000) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock StockManagement = new clsStock();
            String Error = "";
            Error = StockManagement.Valid( ProductName, ProductNo, Price, Date, QuantityOrdered, QuantityInStock );
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsStock StockManagement = new clsStock();
            String Error = "";
            string ProductName = "";
            Error = StockManagement.Valid(ProductName, ProductNo,Price, QuantityInStock, Date, QuantityOrdered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMin()
        {
            clsStock StockManagement = new clsStock();
            String Error = "";
            string ProductName = "a";
            Error = StockManagement.Valid(ProductName, ProductNo,Price, QuantityInStock, Date, QuantityOrdered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsStock StockManagement = new clsStock();
            String Error = "";
            string ProductName = "aa";
            Error = StockManagement.Valid(ProductName, ProductNo,Price, QuantityInStock, Date, QuantityOrdered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLess1()
        {
            clsStock StockManagement = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(19, 'a');
            Error = StockManagement.Valid(ProductName, ProductNo,Price, QuantityInStock, Date, QuantityOrdered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            clsStock StockManagement = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(20, 'a');
            Error = StockManagement.Valid(ProductName, ProductNo,Price, QuantityInStock, Date, QuantityOrdered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStock StockManagement = new clsStock();
            String Error = "";
            string ProductName = "";
            Error = StockManagement.Valid(ProductName, ProductNo,Price, QuantityInStock, Date, QuantityOrdered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMid()
        {
            clsStock StockManagement = new clsStock();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(10, 'a');
            Error = StockManagement.Valid(ProductName, ProductNo,Price, QuantityInStock, Date, QuantityOrdered);
            Assert.AreNotEqual(Error, "");
        }


    }
}

    



using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class
            clsStockCollection AllProducts = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllProducts);
        }
        [TestMethod]
        public void ProductListOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            //create test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add item to list
            //create item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Price = 1.00;
            TestItem.ProductNo = 1;
            TestItem.QuantityInStock = 1;
             
            TestItem.Date = DateTime.Now.Date;
            TestItem.ProductName = "Nike";
            //add item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllProducts.mProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.mProductList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            Int32 SomeCount = 2;
            AllProducts.Count = SomeCount;
            Assert.AreEqual(AllProducts.Count, SomeCount);
        }
        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            //create test data to assign the property
            //create item of test data
            clsStock TestProduct = new clsStock();
            //set its properties
            TestProduct.Price = 1.00;
            TestProduct.ProductNo = 1;
            TestProduct.QuantityOrdered = 1;
            TestProduct.QuantityInStock = 1;
            TestProduct.Date = DateTime.Now.Date;
            TestProduct.ProductName = "Nike";
            //Assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            //create test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add item to list
            //create item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductNo = 1;
            TestItem.Price = 1.00;
            TestItem.QuantityOrdered = 1;
            TestItem.QuantityInStock = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.ProductName = "Nike";
            //add item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property   
            AllProducts.mProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            Assert.AreEqual(AllProducts.Count, 2);
        }
    }
}

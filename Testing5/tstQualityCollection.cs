using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstQualityCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class
            clsQualityCollection AllProducts = new clsQualityCollection();
            //test to see if it exists
            Assert.IsNotNull(AllProducts);
        }
        [TestMethod]
        public void ProductListOK()
        {
            clsQualityCollection AllProducts = new clsQualityCollection();
            //create test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsQuality> TestList = new List<clsQuality>();
            //add item to list
            //create item of test data
            clsQuality TestItem = new clsQuality();
            //set its properties
            TestItem.Defective = false;
            TestItem.ProductNo = 1;
            TestItem.StaffID = 1;
            TestItem.BatchNo = 1;
            TestItem.Grade = 'A';
            TestItem.Date = DateTime.Now.Date;
            TestItem.ProductName = "Blue";
            //add item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsQualityCollection AllProducts = new clsQualityCollection();
            Int32 SomeCount = 0;
            AllProducts.Count = SomeCount;
            Assert.AreEqual(AllProducts.Count, SomeCount);
        }
        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsQualityCollection AllProducts = new clsQualityCollection();
            //create test data to assign the property
            //create item of test data
            clsQuality TestProduct = new clsQuality();
            //set its properties
            TestProduct.Defective = false;
            TestProduct.ProductNo = 1;
            TestProduct.StaffID = 1;
            TestProduct.BatchNo = 1;
            TestProduct.Grade = 'A';
            TestProduct.Date = DateTime.Now.Date;
            TestProduct.ProductName = "Blue";
            //Assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsQualityCollection AllProducts = new clsQualityCollection();
            //create test data to assign the property
            //in this case the data needs to be a list of objects
            List<clsQuality> TestList = new List<clsQuality>();
            //add item to list
            //create item of test data
            clsQuality TestItem = new clsQuality();
            //set its properties
            TestItem.Defective = false;
            TestItem.ProductNo = 1;
            TestItem.StaffID = 1;
            TestItem.BatchNo = 1;
            TestItem.Grade = 'A';
            TestItem.Date = DateTime.Now.Date;
            TestItem.ProductName = "Blue";
            //add item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property   
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsQualityCollection AllProducts = new clsQualityCollection();
            Assert.AreEqual(AllProducts.Count, 2);
        }
    }
}

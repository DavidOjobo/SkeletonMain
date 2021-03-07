using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }
        [TestMethod]
        public void ProductNoOK()
        {
            clsCustomer Customer = new clsCustomer();
            Int32 TestData = 1;
            Customer.ProductNo = TestData;
            Assert.AreEqual(Customer.ProductNo, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCustomer Customer = new clsCustomer();
            Int32 TestData = 2;
            Customer.CustomerID = TestData;
            Assert.AreEqual(Customer.CustomerID, TestData);
        }

        [TestMethod]
        public void FullNameOK()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "Full Name";
            Customer.FullName = TestData;
            Assert.AreEqual(Customer.FullName, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "Email";
            Customer.Email = TestData;
            Assert.AreEqual(Customer.Email, TestData);
        }

        [TestMethod]
        public void OrderNo()
        {
            clsCustomer Customer = new clsCustomer();
            Int32 TestData = 1;
            Customer.OrderNo = TestData;
            Assert.AreEqual(Customer.OrderNo, TestData);
        }

        [TestMethod]
        public void PhoneNumber()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "00000000000";
            Customer.PhoneNumber = TestData;
            Assert.AreEqual(Customer.PhoneNumber, TestData);
        }
        [TestMethod]
        public void Address()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "12 Smith Road";
            Customer.Address = TestData;
            Assert.AreEqual(Customer.Address, TestData);
        }
        [TestMethod]
        public void DateOK()
        {
            clsCustomer Customer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            Customer.Date = TestData;
            Assert.AreEqual(Customer.Date, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        { 
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Int32 ProductNo = 1;
            Found = Customer.Find(ProductNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductNoFoundOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
             Int32 ProductNo = 1;
            //invoke the method
            Found = Customer.Find(ProductNo);
            //check the address no
            if (Customer.ProductNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestCustomerID()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = Customer.Find(ProductNo);
            //check the address no
            if (Customer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestFullNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = Customer.Find(ProductNo);
            //check the address no
            if (Customer.FullName != "Full Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestEmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = Customer.Find(ProductNo);
            //check the address no
            if (Customer.Email != "Email@")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestOrderNo()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = Customer.Find(ProductNo);
            //check the address no
            if (Customer.OrderNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestPhoneNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = Customer.Find(ProductNo);
            //check the address no
            if (Customer.PhoneNumber != "079338432901")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestAddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = Customer.Find(ProductNo);
            //check the address no
            if (Customer.Address != "12 Smith Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestDateOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the method
            Found = Customer.Find(ProductNo);
            //check the address no
            if (Customer.Date != Convert.ToDateTime("01/01/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }

}

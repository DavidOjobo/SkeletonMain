using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        String FullName = "John Smith";
        String PhoneNumber = 01234567891.ToString();
        String Email = "abcde@hotmail.com";
        String Address = "96 Waterloo Road";
        String Date = DateTime.Now.Date.ToString();
        //String OrderNo = 5555.ToString();
        String CustomerID = 1.ToString();
        //String Active = Boolean.ToString();

    
    
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //Test to see if it exists
            Assert.IsNotNull(Customer);
        }
    

    [TestMethod]
    public void ActivePropertyOK()
    {
        //create an instance of the class we want to create
        clsCustomer Customer = new clsCustomer();
        //create some test data
        Boolean TestData = true;
        //Assign data to property
        Customer.Active = TestData;
        //Test to see if the two values are the same
        Assert.AreEqual(Customer.Active, TestData);

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
            String TestData = "FullName";
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

    /* [TestMethod]
     public void OrderNoOK()
     {
         clsCustomer Customer = new clsCustomer();
         Int32 TestData = 5555;
         Customer.OrderNo = TestData;
         Assert.AreEqual(Customer.OrderNo, TestData);
     } */

    [TestMethod]
        public void PhoneNumberOK()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "01234567891";
            Customer.PhoneNumber = TestData;
            Assert.AreEqual(Customer.PhoneNumber, TestData);
        }
        [TestMethod]
        public void AddressOK()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "12 Smith Road";
            Customer.Address = TestData;
            Assert.AreEqual(Customer.Address, TestData);
        }
        [TestMethod]
        public void DateOK()
        {
            //create an instance for the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data and assign it to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Customer.Date = TestData;
            //test to see if the values are the same
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









        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance for the class Customer
            clsCustomer Customer = new clsCustomer();
            //String variable to store the Error message
            String Error = "";
            Error = Customer.Valid(FullName, Email, PhoneNumber, Date, Address, CustomerID);
            Assert.AreEqual(Error, "");
        }
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "a"; //this should be ok
            //invoke the method
            Error = Customer.Valid(FullName, Email, PhoneNumber, Date, Address, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aa"; //this should be ok
            //invoke the method
            Error = Customer.Valid(FullName, Email, PhoneNumber, Date, Address, CustomerID);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaa"; //this should be ok
            //invoke the method
            Error = Customer.Valid(FullName, Email, PhoneNumber, Date, Address, CustomerID);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaaaaa"; //this should be ok
            //invoke the method
            Error = Customer.Valid(FullName, Email, PhoneNumber, Date, Address, CustomerID);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "aaa"; //this should be ok
            //invoke the method
            Error = Customer.Valid(FullName, Email, PhoneNumber, Date, Address, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }

}



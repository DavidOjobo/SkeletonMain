using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        String FullName = "Some Name";
        String PhoneNumber = "09876543210";
        String Email = "Some@Test.com";
        String Address = "2 Some Street";
        String Date = DateTime.Now.Date.ToString();
        Int32 ProductNo = 25;
        Int32 CustomerID = 1;
        String PostCode = "TTT TTT";
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
        public void PostCodeOK()
        {
            clsCustomer Customer = new clsCustomer();
            String TestData = "LE1 5NY";
            Customer.PostCode = TestData;
            Assert.AreEqual(Customer.PostCode, TestData);
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
            Int32 CustomerID = 1;
            Found = Customer.Find(CustomerID);
            Assert.IsTrue(Found);
        }




        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestProductNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.ProductNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }


       


        [TestMethod]
        public void TestFullNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.FullName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.Email != "Test@outlook.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        /* [TestMethod]
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

        */

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.PhoneNumber != "01234567891") 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.Address != "1 Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.Date != Convert.ToDateTime("01/01/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = Customer.Find(CustomerID);
            //check the address no
            if (Customer.PostCode != "XXX XXX")
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
            Error = Customer.Valid(FullName, Address, PostCode,Email, Date, PhoneNumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaa"; //this should be ok
                                    //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        [TestMethod]

        public void FullNameNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaa"; //this should be ok
                                       //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






        [TestMethod]

        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaa"; //this should be ok
                                       //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]

        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaa"; //this should be ok
                                     //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]

        public void FullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "";
            FullName = FullName.PadRight(500, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }








        [TestMethod]
        public void DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
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
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }







        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
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
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Date = TestDate.ToString();
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
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
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
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
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string Date = "This is NOT a date";
                    //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }







        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "a";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "";
            PostCode = PostCode.PadRight(11, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaa";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void AddressLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "a";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
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
            //this should pass
            string Address = "aa";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
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
            //this should pass
            string Address = "";
            Address = Address.PadRight(59,'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(60, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(30, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void EmailLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(79, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(80, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(81, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(40, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void PhoneNumberLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "a";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMinPlus()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "aa";
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(19, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(20, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(21, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(10, 'a');
            //invoke the method
            Error = Customer.Valid(FullName, Address, PostCode, Email, Date, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }

}



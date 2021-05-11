using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        private object AnStaff;

        public bool StaffID { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {

            clsStaff StaffManagement = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {

            clsStaff StaffManagement = new clsStaff();
            Boolean TestData = true;
            AnStaff.StaffID = TestData;
            Assert.AreEqual(StaffID, TestData);
        }
   
        [TestMethod]
        public void DateAddedPropertyOK()
        {

            clsStaff StaffManagement = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnStaff.DateAdded = TestData;
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsStaff StaffManagement = new clsStaff();
            Int32 TestData = 1;
            Staff.OrderNo = TestData;
            Assert.AreEqual(Staff.OrderNo);
        }
    
        [TestMethod]
        public void PricePropertyOK()
        {

            clsStaff StaffManagement = new clsStaff();
            Int32 TestData = 1;
            AnStaff.Price = TestData;
            Assert.AreEqual(AnStaff.Price, TestData);
        }
    
        [TestMethod]
        public void ProductNamePropertyOK()
        {

            clsStaff StaffManagement = new clsStaff();
            string TestData = "ProductName";
            AnStaff.ProductName = TestData;
            Assert.AreEqual(AnStaff.ProductName, TestData);
        }
    
        [TestMethod]
        public void ProductNoPropertyOK()
        {
            clsStaff StaffManagement = new clsStaff();
            int TestData = 1;
            AnStaff.ProductNo = TestData;
            Assert.AreEqual(AnStaff.ProductNo, TestData);
        }
    
        [TestMethod]
        public void ShippedStatusPropertyOK()
        {
            clsStaff StaffManagement = new clsStaff();
            string TestData = "Shipped Status";
            AnStaff.ShippedStatus = TestData;
            Assert.AreEqual(AnStaff.ShippedStatus, TestData);
        }

    }
           [TestMethod]
            public void FindMethodOK()
            {
                clsStaff StaffManagement = new clsStaff();
                Boolean Found = false;
                Int32 ProductNo = 1;
                Found = StaffManagement.Find(ProductNo);
                Assert.IsTrue(Found);
            }

    [TestMethod]
    public void TestProductNoFound()
    {
        clsStaff StaffManagement = new clsStaff();
        Boolean Found = false;
        Boolean OK = true;
        Int32 ProductNo = 1;
        Found = StaffManagement.Find(ProductNo);
        if (StaffManagement.ProductNo != 1)
        {
            OK = false;
        }
        Assert.IsTrue(OK);

    }

    [TestMethod]
    public void TestProductNameFound()
    {
        clsStaff StaffManagement = new clsStaff();
        Boolean Found = false;
        Boolean OK = true;
        Int32 ProductNo = 1;
        Found = StaffManagement.Find(ProductNo);
        if (StaffManagement.ProductName != 1)
        {
            OK = false;
        }
        Assert.IsTrue(OK);
    }
    [TestMethod]
    public void TestStaffIDFound()
    {
        clsStaff StaffManagement = new clsStaff();
        Boolean Found = false;
        Boolean OK = true;
        Int32 ProductNo = 1;
        Found = StaffManagement.Find(ProductNo);
        if (StaffManagement.StaffID != 1)
        {
            OK = false;
        }
        Assert.IsTrue(OK);
    }


    [TestMethod]
    public void TestOrderNoFound()
    {
        clsStaff StaffManagement = new clsStaff();
        Boolean Found = false;
        Boolean OK = true;
        Int32 ProductNo = 1;
        Found = StaffManagement.Find(ProductNo);
        if (StaffManagement.OrderNo != 1)
        {
            OK = false;
        }
        Assert.IsTrue(OK);
    }


    [TestMethod]
    public void TestOrderNoFound()
    {
        clsStaff StaffManagement = new clsStaff();
        Boolean Found = false;
        Boolean OK = true;
        Int32 ProductNo = 1;
        Found = StaffManagement.Find(ProductNo);
        if (StaffManagement.OrderNo != 1)
        {
            OK = false;
        }
        Assert.IsTrue(OK);
    }

    public void TestDateAddedFound()
    {

        clsStaff StaffManagement = new clsStaff();
        Boolean Found = false;
        Boolean OK = true;
        Int32 ProductNo = 1;
        Found = StaffManagement.Find(ProductNo);
        if (AnAddress.DateAdded != Convert.ToDateTime("05/05/2021"))
        {
            OK = false;
        }
        Assert.IsTrue(OK);
    }

    [TestMethod]
    public void TestShippedStatusFound()
    {
        clsStaff StaffManagement = new clsStaff();
        Boolean Found = false;
        Boolean OK = true;
        Int32 ProductNo = 1;
        Found = StaffManagement.Find(ProductNo);
        if (StaffManagement.ShippedStatus != 1)
        {
            OK = false;
        }
        Assert.IsTrue(OK);

    }








        {
    }
}

using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstQuality
    {
        String ProductName = "Blue";
        String StaffID = 1.ToString();
        String BatchNo = 1.ToString();
        String Date = DateTime.Now.Date.ToString();
        String Grade = 'A'.ToString();
        String Defective = true.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //creates instance of class
            clsQuality QualityControl = new clsQuality();
            //tests to see if it exists
            Assert.IsNotNull(QualityControl);
        }
        [TestMethod]
        public void DefectivePropertyOK()
        {
            //create instance of class
            clsQuality QualityControl = new clsQuality();
            //create test data
            Boolean TestData = false;
            //assign data to property
            QualityControl.Defective = TestData;
            //test to see if values are the same
            Assert.AreEqual(QualityControl.Defective, TestData);

        }
        [TestMethod]
        public void DatePropertyOK()
        {
            //create instance of class
            clsQuality QualityControl = new clsQuality();
            //create test with datatype DateTime
            DateTime TestData = DateTime.Now.Date;
            //Assign data with property
            QualityControl.Date = TestData;
            //Test to see if they are equal
            Assert.AreEqual(QualityControl.Date, TestData);
        }
        [TestMethod]
        public void GradePropertyOK()
        {
            //create class instance
            clsQuality QualityControl = new clsQuality();
            //create test for property
            Char TestData = 'A';
            //assign data to property
            QualityControl.Grade = TestData;
            //test for if they are equal
            Assert.AreEqual(QualityControl.Grade, TestData);

        }
        [TestMethod]
        public void BatchNoPropertyOK()
        {
            clsQuality QualityControl = new clsQuality();
            Int32 DataTest = 1;
            QualityControl.BatchNo = DataTest;
            Assert.AreEqual(QualityControl.BatchNo, DataTest);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsQuality QualityControl = new clsQuality();
            Int32 DataTest = 1;
            QualityControl.StaffID = DataTest;
            Assert.AreEqual(QualityControl.StaffID, DataTest);

        }
        [TestMethod]
        public void ProductNoPropertyOK()
        {
            clsQuality QualityControl = new clsQuality();
            Int32 DataTest = 1;
            QualityControl.ProductNo = DataTest;
            Assert.AreEqual(QualityControl.ProductNo, DataTest);
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsQuality QualityControl = new clsQuality();
            String DataTest = "Blue";
            QualityControl.ProductName = DataTest;
            Assert.AreEqual(QualityControl.ProductName, DataTest);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsQuality QualityControl = new clsQuality();
            Boolean Found = false;
            Int32 ProductNo = 1;
            Found = QualityControl.Find(ProductNo);
            Assert.IsTrue(Found);
        }
       
        [TestMethod]
        public void TestProductNoFound()
        {
            clsQuality QualityControl = new clsQuality();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 1;
            Found = QualityControl.Find(ProductNo);
            if (QualityControl.ProductNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDateFound()
        {
            clsQuality QualityControl = new clsQuality();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 1;
            Found = QualityControl.Find(ProductNo);
            if (QualityControl.Date != Convert.ToDateTime("01/01/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffIDFound()
        {
            clsQuality QualityControl = new clsQuality();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 1;
            Found = QualityControl.Find(ProductNo);
            if (QualityControl.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestBatchNoFound()
        {
            clsQuality QualityControl = new clsQuality();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 1;
            Found = QualityControl.Find(ProductNo);
            if (QualityControl.BatchNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestGradeFound()
        {
            clsQuality QualityControl = new clsQuality();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 1;
            Found = QualityControl.Find(ProductNo);
            if (QualityControl.Grade != 'A')
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDefectiveFound()
        {
            clsQuality QualityControl = new clsQuality();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 1;
            Found = QualityControl.Find(ProductNo);
            if (QualityControl.Defective != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestProductNameFound()
        {
            clsQuality QualityControl = new clsQuality();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 1;
            Found = QualityControl.Find(ProductNo);
            if (QualityControl.ProductName != "Blue")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsQuality QualityControl = new clsQuality();
            String Error = "";
            Error = QualityControl.Valid(ProductName, StaffID, BatchNo, Grade, Date, Defective);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsQuality QualityControl = new clsQuality();
            String Error = "";
            string ProductName = "";
            Error = QualityControl.Valid(ProductName, StaffID, BatchNo, Grade, Date, Defective);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMin()
        {
            clsQuality QualityControl = new clsQuality();
            String Error = "";
            string ProductName = "a";
            Error = QualityControl.Valid(ProductName, StaffID, BatchNo, Grade, Date, Defective);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsQuality QualityControl = new clsQuality();
            String Error = "";
            string ProductName = "aa";
            Error = QualityControl.Valid(ProductName, StaffID, BatchNo, Grade, Date, Defective);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLess1()
        {
            clsQuality QualityControl = new clsQuality();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(19, 'a');
            Error = QualityControl.Valid(ProductName, StaffID, BatchNo, Grade, Date, Defective);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            clsQuality QualityControl = new clsQuality();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(20, 'a');
            Error = QualityControl.Valid(ProductName, StaffID, BatchNo, Grade, Date, Defective);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsQuality QualityControl = new clsQuality();
            String Error = "";
            string ProductName = "";
            Error = QualityControl.Valid(ProductName, StaffID, BatchNo, Grade, Date, Defective);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMid()
        {
            clsQuality QualityControl = new clsQuality();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(10, 'a');
            Error = QualityControl.Valid(ProductName, StaffID, BatchNo, Grade, Date, Defective);
            Assert.AreNotEqual(Error, "");
        }

       
    }
}

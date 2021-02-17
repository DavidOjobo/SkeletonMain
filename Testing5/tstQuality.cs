using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstQuality
    {
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
            Boolean TestData = true;
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
            String DataTest = 1;
            QualityControl.ProductNo = DataTest;
            Assert.AreEqual(QualityControl.ProductNo, DataTest);
        }

        

    }
}

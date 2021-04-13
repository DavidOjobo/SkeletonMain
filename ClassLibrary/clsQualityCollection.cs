using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsQualityCollection
    {
        public clsQualityCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblQuality_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank address
                clsQuality QualityControl = new clsQuality();
                //read in the fields from the current record
                QualityControl.Defective = Convert.ToBoolean(DB.DataTable.Rows[Index]["Defective"]);
                QualityControl.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                QualityControl.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                QualityControl.BatchNo = Convert.ToInt32(DB.DataTable.Rows[Index]["BatchNo"]);
                QualityControl.Grade = Convert.ToChar(DB.DataTable.Rows[Index]["Grade"]);
                QualityControl.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                QualityControl.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                //add the record to the private data member
                mProductList.Add(QualityControl);
                //point at the next record
                Index++;
            }
        }
        List<clsQuality> mProductList = new List<clsQuality>();
        public List<clsQuality> ProductList
        {
            get
            {
                return mProductList;
            }
            set
            {
                mProductList = value;
            }
        }
        public int Count
        {
            get
            {
                return mProductList.Count;
            }
            set
            {

            }
        }
        public clsQuality ThisProduct { get; set; }
    }
}
using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        


        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
        


         }
        public void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mProductList = new List<clsStock>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank QuantityInStock
                clsStock StockManagement = new clsStock();
                //read in the fields from the current record
                StockManagement.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                StockManagement.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                StockManagement.QuantityOrdered = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityOrdered"]);
                StockManagement.QuantityInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityInStock"]);
                StockManagement.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                StockManagement.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                //add the record to the private data member
                mProductList.Add(StockManagement);
                //point at the next record
                Index++;

            }

        }

        List<clsStock> ProductList = new List<clsStock>();
        private clsStock mThisProduct;

        public List<clsStock> mProductList
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

        public void ReportByProductNo(object text)
        {
            throw new NotImplementedException();
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
        public clsStock ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@ProductNo", mThisProduct.ProductNo);
            DB.AddParameter("@Date", mThisProduct.Date);
            DB.AddParameter("@QuantityOrdered", mThisProduct.QuantityOrdered);
            DB.AddParameter("@QuantityInStock", mThisProduct.QuantityInStock);
            return DB.Execute("sproc_tblStock_Insert");



        }
        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@QuantityInStock", mThisProduct.QuantityInStock);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@ProductNo", mThisProduct.ProductNo);
            DB.AddParameter("@Date", mThisProduct.Date);
            DB.AddParameter("@QuantityOrdered", mThisProduct.QuantityOrdered);
            return DB.Execute("sproc_tblStock_Update");


        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductNo", mThisProduct.ProductNo);
            //DB.AddParameter("@Active", mThisProduct.Active);
            DB.Execute("sproc_tblStock_Delete");

        }
        public void ReportByProductNo(string ProductNo)
        {
            //Filters the record based on Full or Partial name
            //Connects to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the Full Name parameter to the database
            DB.AddParameter("@ProductNo", ProductNo);
            //Execute the stored procedure
            DB.Execute("sproc_tbl_Stock_FilterByProductNo");
            PopulateArray(DB);
        }

       
    }
}

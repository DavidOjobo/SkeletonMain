﻿using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        

        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank QuantityInStock
                clsStock StockManagement = new clsStock();
                //read in the fields from the current record
                StockManagement.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                StockManagement.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                StockManagement.QuantityOrdered = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityOrdered"]);
           ;    StockManagement.QuantityInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityInStock"]);
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
    }
}

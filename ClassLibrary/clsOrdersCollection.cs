using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        //publc property for address list 
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }

        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
            }
        }
        public void clsOrderCollection()
        {
            clsOrder TestItem = new clsOrder();
            TestItem.ProductName = "kenny";
            TestItem.ProductNo = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Price = 84.0000;
            TestItem.OrderNo = 1;
            //TestItem.OrderNo = 1;
            mOrderList.Add(TestItem);
            TestItem = new clsOrder();
            TestItem.ProductName = "kenny";
            TestItem.ProductNo = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Price = 84.0000;
            TestItem.OrderNo = 1;
            //TestItem.OrderNo = 1;
            mOrderList.Add(TestItem);
        }
        public clsOrdersCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank address
                clsOrder Order = new clsOrder();
                //read in the fields from the current record
                Order.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                Order.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                Order.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                Order.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                Order.Price = Convert.ToChar(DB.DataTable.Rows[Index]["Price"]);
                Order.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                //add the record to the private data member
                mOrderList.Add(Order);
                //point at the next record
                Index++;
            }



        }

    }
}
    

using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();   

        public clsOrdersCollection()
        {
            Int32 Index = 0;
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
        //List<clsOrder> mProductList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mThisOrder.ProductName);
            DB.AddParameter("@ProductNo", mThisOrder.ProductNo);
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@Dispatched", mThisOrder.Dispatched);
            return DB.Execute("sproc_tblOrder_Insert");

        }
    }

}

    

using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();   

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
        List<clsOrder> mProductList = new List<clsOrder>();
        public List<clsOrder> ProductList
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
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", mOrderList.ProductName);
            DB.AddParameter("@ProductNo", mOrderList.ProductNo);
            DB.AddParameter("@OrderNo", mOrderList.OrderNo);
            DB.AddParameter("@Price", mOrderList.Price);
            DB.AddParameter("@Date", mOrderList.Date);
            DB.AddParameter("@Dispatched", mOrderList.Dispatched);
            return DB.Execute("sproc_tblOrder_Insert");

        }
    }

    public class clsOrderCollection
    {
        public List<clsOrder> OrderList { get; set; }
        public int Count { get; set; }
        public clsOrder ThisOrder { get; set; }
    }

}
}
    

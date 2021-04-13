using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        
        public clsCustomerCollection()

        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_FJ_SelectAll");
            RecordCount = DB.Count;
            while (Index > RecordCount)
            {
                clsCustomer Customer = new clsCustomer();
                Customer.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                Customer.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Customer.PhoneNumber = Convert.ToInt64(DB.DataTable.Rows[Index]["Phone Number"]);
                Customer.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                Customer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["Full Name"]);
                //Active = Convert.ToString(DB.DataTable.Rows[Index]["Full Name"]);
                mCustomerList.Add(Customer);
                Index++;
            }

        }
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer { get; set; }



    }


}
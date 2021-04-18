using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        //Constructor for class
        public clsCustomerCollection()

        {
            //Var for Index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount = 0;
            //Object for Data Connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FJ_SelectAll");
            //Get Count for records
            RecordCount = DB.Count;
            //While there are records to process
            while (Index > RecordCount)
            {
                //Create blank Customer
                clsCustomer Customer = new clsCustomer();
                //Read in the fields for the current records
                Customer.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                Customer.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Customer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["Phone Number"]);
                Customer.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                Customer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["Full Name"]);
                //Active = Convert.ToString(DB.DataTable.Rows[Index]["Full Name"]);
                //Add the record to private data member
                mCustomerList.Add(Customer);
                //Point at the next record
                Index++;
            }

        }


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
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@OrderNo", mThisCustomer.OrderNo);
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Date", mThisCustomer.Date);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            //DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tblCustomer_FJ_Insert");



        }
        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@OrderNo", mThisCustomer.OrderNo);
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Date", mThisCustomer.Date);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            //DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tblCustomer_FJ_Update");


        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductNo", mThisCustomer.ProductNo);
            //DB.AddParameter("@Active", mThisCustomer.Active);
            DB.Execute("sproc_tblCustomer_FJ_Delete");


        }

        public void ReportByFullName(string FullName)
        {
            //Filters the record based on Full or Partial name
            //Connects to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the Full Name parameter to the database
            DB.AddParameter("@FullName", FullName);
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FJ_FilterByFullName");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //Populates the array list based on the data in the table in the parameter DB

            //Var for Index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount;
            //Get the count of records
            RecordCount = DB.Count;
            //Clear the private array list
            mCustomerList = new List<clsCustomer>();
            //While there are records to process
            while (Index < RecordCount)
            {
                clsCustomer Customer = new clsCustomer();
                Customer.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                Customer.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                Customer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["Phone Number"]);
                Customer.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                Customer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["Full Name"]);
                //Active = Convert.ToString(DB.DataTable.Rows[Index]["Full Name"]);

                //Add the record to the private data member
                mCustomerList.Add(Customer);
                //Point at the next record
                Index++;
            }
        }

    }

  


}
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
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tbl_Customer_FJ_SelectAll");
            PopulateArray(DB);
        }

            public void PopulateArray(clsDataConnection DB)
            {
                Int32 Index = 0;
                Int32 RecordCount = 0;
                RecordCount = DB.Count;
                 mCustomerList = new List<clsCustomer>();
      
                //While there are records to process
                while (Index < RecordCount)
                {
                    //Create blank Customer
                    clsCustomer Customer = new clsCustomer();
                    //Read in the fields for the current records
                    //Customer.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                    Customer.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                    Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                    Customer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                    Customer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                    Customer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                    Customer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                    Customer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                    Customer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
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
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Date", mThisCustomer.Date);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tbl_Customer_FJ_Insert");



        }
        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Date", mThisCustomer.Date);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Active", mThisCustomer.Active);
            return DB.Execute("sproc_tbl_Customer_FJ_Update");


        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //DB.AddParameter("@Active", mThisCustomer.Active);
            DB.Execute("sproc_tbl_Customer_FJ_Delete");


        }

        public void ReportByFullName(string FullName)
        {
            //Filters the record based on Full or Partial name
            //Connects to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the Full Name parameter to the database
            DB.AddParameter("@FullName", FullName);
            //Execute the stored procedure
            DB.Execute("sproc_tbl_Customer_FJ_FilterByFullName");
            PopulateArray(DB);
        }

       
  
            }
        }

   
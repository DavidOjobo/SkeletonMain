using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private int mProductNo;
    
        public int ProductNo
        {
            get
            {
                return mProductNo;
           
            }
            set
            {
                mProductNo = value;
            }

        }

        private int mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;

            }
            set
            {
                mCustomerID = value;
            }

        }

        private string mFullName;
        public string FullName
        {
            get
            {
                return mFullName;

            }
            set
            {
                mFullName = value;
            }

        }

        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;

            }
            set
            {
                mEmail = value;
            }

        }

        private int mOrderNo;
        public int OrderNo
        {
            get
            {
                return mOrderNo;

            }
            set
            {
                mOrderNo = value;
            }

        }

        private string mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;

            }
            set
            {
                mPhoneNumber = value;
            }

        }

      

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;

            }
            set
            {
                mAddress = value;
            }

        }

       

        

        private DateTime mDate;
        public DateTime Date
        {
            get
            {
                return mDate;

            }
            set
            {
                mDate = value;
            }

        }


        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }


        private string mPostCode;
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }



       
        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //Execute the stored procedure
            DB.Execute("sproc_tbl_Customer_FJ_FilterByCustomerID");
            if (DB.Count == 1)

            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                    //mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
               
                //copy the data from the database to the private data members
                return true;
                }
                //if no record was found
                else
{
                //return false indicating problem
                return false;
            

        }


    }

        public string Valid(string FullName, string email, string PhoneNumber, string date, string address, string PostCode, int ProductNo)
        {
            String Error = "";
            DateTime DateTemp;

            if (Address.Length == 0)
            {
                Error = Error + "The address may not be blank";
            }
            return Error;
            

        
            {
                
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }

        }

        public string Valid(string fullName, string email, string phoneNumber, string date, string address, string postCode, string productNo)
        {
            throw new NotImplementedException();
        }
    }
}
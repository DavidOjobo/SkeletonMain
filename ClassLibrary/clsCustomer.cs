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
                //mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
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
        public string Valid(string FullName, string Address, string PostCode, string Email, string Date, string PhoneNumber)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the FullName is blank
            if (FullName.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (FullName.Length < 3)
            {
                //record the error
                Error = Error + "The Full Name must be more than 6 characters : ";
            }
            try
            {
                //copy the date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateTime.Today.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Today.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (PostCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (PostCode.Length > 10)
              
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
                Error = Error + PostCode;
            }
            //is the Address blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the Address is too long
            if (Address.Length > 60)
            {
                //record the error
                Error = Error + "The Address must be less than 60 characters : ";
            }
            //is the Email blank
            if (Email.Length == 0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the Email is too long
            if (Email.Length > 80)
            {
                //record the error
                Error = Error + "The Email must be less than 80 characters : ";
            }


            //is the PhoneNumber blank
            if (PhoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The PhoneNumber may not be blank : ";
            }
            //if the Email is too long
            if (PhoneNumber.Length > 20)
            {
                //record the error
                Error = Error + "The Phone Number must be less than 20 characters : ";
            }

            //return any error messages
            return Error;
        }


    }
}
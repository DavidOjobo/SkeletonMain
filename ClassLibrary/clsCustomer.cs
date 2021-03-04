using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private String mProductNo;



        public string ProductNo
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

        private String mFullName;
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

        private String mEmail;
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

        private String mPhoneNumber;
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

        private String mAddress;
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

        public bool Find(string productNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@ProductNo", ProductNo);
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FJ_FilterByProductNo");
            if(DB.Count == 1)
                
                {
                    mProductNo = Convert.ToString(DB.DataTable.Rows[0]["ProductNo"]);
                    mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                    mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                    mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                    mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                    mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["Phone Number"]);
                    mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                    mFullName = Convert.ToString(DB.DataTable.Rows[0]["Full Name"]);
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
}
}
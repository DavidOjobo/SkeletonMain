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
            mProductNo = "1a";
            mDate = Convert.ToDateTime("01/01/2021");
            mCustomerID = 2;
            mEmail = "1a";
            mAddress = "1a";
            mPhoneNumber = "00000000000";
            mOrderNo = 1;
            mFullName = "1a";
            
            return true;
        }
    }
}
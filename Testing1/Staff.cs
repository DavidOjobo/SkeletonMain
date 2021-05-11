using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsStaff
    {


        private Int32 mProductNo;
        public bool Active
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

 
        private Int32 mOrderNo;
 
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

 
        private Int32 mStaffI;

        public int StaffID
        {
            get
            {

                return mStaffID;
            }
            set
            {

                mStaffID = value;
            }
        }


        private string mProductName;
 
        public string ProductName
        {
            get
            {

                return mProductName;
            }
            set
            {

                mProductName = value;
            }
        }


        private string mShippedStatus;

        public string ShippedStatus
        {
            get
            {

                return mShippedStatus;
            }
            set
            {

                mShippedStatus = value;
            }
        }


      

        public bool Find(int ProductNo)
        {
            mProductNo = 1;
            mOrderNo = "1";
            mProductName = "Item";
            mShippedStatus = "Delivered";
            mDate = Convert.ToDateTime("05/05/2021");
            mStaff = true;
            return true;
        }
    }
}

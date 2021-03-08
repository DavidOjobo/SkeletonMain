using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }
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
        private String mProductName;
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
        private double mPrice;
        public double Price
        {
            get
            {
                return mPrice;

            }
            set
            {
                mPrice = value;
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
        private bool mDispatched;
        public bool Dispatched
        {
            get
            {
                return mDispatched;

            }
            set
            {
                mDispatched = value;
            }
        }
    

        public bool Find(int productNo)
        {
            mProductNo = 1;
            mProductName = "kenny";
            mOrderNo = 1; 
            mPrice = 84.000;
            mDate = Convert.ToDateTime("01/01/21");
            mDispatched = true;
        return true;
        }
    }
}
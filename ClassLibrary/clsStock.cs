using System;

namespace ClassLibrary
{
    public class clsStock
    { 
        public clsStock()
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
        private int mQuantityOrdered;
        public int OrderNo
        {
            get
            {
                return mQuantityOrdered;
            }
            set
            {
                mQuantityOrdered = value;
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
        private int mQuantityInStock;
        public int QuantityInStock
        {
            get
            {
                return mQuantityInStock;

            }
            set
            {
                mQuantityInStock = value;
            }
        }


        public bool Find(int productNo)
        {
            mProductNo = 1;
            mProductName = "Nike";
            mPrice = 420.69;
            mDate = Convert.ToDateTime("01/01/21");
            mQuantityInStock= 2000;
            mQuantityOrdered = 400;
            return true;
        }
    }
}
    

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


      

        public bool Find(Int32 productNo)
        {
            //create instance of class
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductNo", ProductNo);
            DB.Execute("[dbo].sproc_tblQuality_FilterByProductNo");
            if (DB.Count == 1)
            {
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mQuantityOrdered = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityOrdered"]);
                mQuantityInStock = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityInStock"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                //always return true
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

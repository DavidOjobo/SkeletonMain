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
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search fror
            DB.AddParameter("@addressNo", AddressNo);
            //executethe stored procedure
            DB.Execute("sproc_tblAddress_FilterByAddressNo");
            //if one record is found  (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mDate= Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                //return that everything worked ok
                return true;
            }
            //if no record was founnd
            else
            {
                return false;
            }
           
            
        }
        
        }
        
}





























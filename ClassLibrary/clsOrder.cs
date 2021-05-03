using System;

namespace ClassLibrary
{
    public class clsOrder
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
            DB.AddParameter("@productNo", ProductNo);
            //executethe stored procedure
            DB.Execute("sproc_tblOrder_FilterByProductNo");
            //if one record is found  (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mProductNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
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
        public string Valid(string productNo, string productName, string orderNo, string price, string date)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the FullName is blank
            if (productName.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (productName.Length < 3)
            {
                //record the error
                Error = Error + "The productName must be more than 6 characters : ";
            }
            try
            {
                //copy the date value to the DateTemp variable
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
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (price.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (price.Length > 10)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }
            //is the Address blank
            if (orderNo.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the Address is too long
            if (orderNo.Length > 60)
            {
                //record the error
                Error = Error + "The Address must be less than 60 characters : ";
            }


        }

    }   
        
}



    




























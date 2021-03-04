using System;

namespace ClassLibrary
{
    public class clsQuality
    {
        
        private bool mDefective;
        public bool Defective
        {
            get
            {
                return mDefective;
            }
            set
            {
                mDefective = value;
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
        private char mGrade;
        public char Grade
        {
            get
            {
                return mGrade;
            }
            set
            {
                mGrade = value;
            }
        }
        private int mBatchNo;
        public int BatchNo
        {
            get
            {
                return mBatchNo;
            }
            set
            {
                mBatchNo = value;
            }
        }
        private int mStaffID;
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
        //private data member for ProductNo
        private String mProductNo;
        public String ProductNo
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
        public bool Find(string productNo)
        {
            //create instance of class
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductNo", ProductNo);
            DB.Execute("sproc_tblQuality_FilterByProductNo");
            if (DB.Count == 1)
            {
                mProductNo = Convert.ToString(DB.DataTable.Rows[0]["ProductNo"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mBatchNo = Convert.ToInt32(DB.DataTable.Rows[0]["BatchNo"]);
                mGrade = Convert.ToChar(DB.DataTable.Rows[0]["Grade"]);
                mDefective = Convert.ToBoolean(DB.DataTable.Rows[0]["Defective"]);
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
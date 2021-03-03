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
            mProductNo = "1";
            mDate = Convert.ToDateTime("01/01/2021");
            mStaffID = 1;
            mBatchNo = 1;
            mGrade = 'C';
            mDefective = true;
            //always return true
            return true;
        }
    }
}
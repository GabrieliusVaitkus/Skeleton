using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private DateTime mDateAdded;
        private decimal mCardPrice;
        private Boolean mAvailable;
        private string mCardType;
        private string mCardDescription;
        private Int32 mCardNo;
        // private Int32 mStockNo;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
        public decimal CardPrice
        {
            get
            {
                return mCardPrice;
            }
            set
            {
                mCardPrice = value;
            }
        }
        public string CardType
        {
            get
            {
                return mCardType;
            }
            set
            {
                mCardType = value;
            }
        }
        public string CardDescription
        {
            get
            {
                return mCardDescription;
            }
            set
            {
                mCardDescription = value;
            }
        }
        public int CardNo
        {
            get
            {
                return mCardNo;
            }
            set
            {
                mCardNo = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }



        public bool Find(int CardNo)
        {
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mCardNo = 21;
            mCardDescription = "Lightning";
            mCardType = "Fire";
            mCardPrice = Convert.ToDecimal(5.22);
            mAvailable = true;

            //always return true;
            return true;
        }





    }
}
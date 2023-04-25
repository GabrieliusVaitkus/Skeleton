using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private DateTime mDateAdded;
        private decimal mPrice;
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
        public decimal Price
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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CardNo", CardNo);
            DB.Execute("sproc_tblStock_FilterByCardNo");
            if (DB.Count == 1)
            {
                mCardNo = Convert.ToInt32(DB.DataTable.Rows[0]["CardNo"]);
                mCardDescription = Convert.ToString(DB.DataTable.Rows[0]["CardDescription"]);
                mCardType = Convert.ToString(DB.DataTable.Rows[0]["CardType"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                return true;
            }
            else
            {
                return false;
            }

        }







            








    }
}
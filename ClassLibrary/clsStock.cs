using System;
using System.Collections.Generic;

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

        public List<clsStock> StockList { get; set; }

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

        public string Valid(string Price, string CardDescription, string CardType, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (Price.Length == 0)
            {
                //record the error
                Error = Error + "The Price may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (Price.Length > 6)
            {
                //record the error
                Error = Error + "The Price must be less than 6 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
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
            

            //is the street blank
            if (CardDescription.Length == 0)
            {
                //record the error
                Error = Error + "The Card Description may not be blank : ";
            }
            //if the street is too long
            if (CardDescription.Length > 50)
            {
                //record the error
                Error = Error + "The Card Description must be less than 50 characters : ";
            }
            //is the town blank
            if (CardType.Length == 0)
            {
                //record the error
                Error = Error + "The Card Type may not be blank : ";
            }
            //if the town is too long
            if (CardType.Length > 50)
            {
                //record the error
                Error = Error + "The Card Type must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }

    }
}
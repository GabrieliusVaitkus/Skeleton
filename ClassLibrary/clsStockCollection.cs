using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);


        }
        //List<clsStock> mStockList = new List<clsStock>();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CardDescription", mThisStock.CardDescription);
            DB.AddParameter("@CardType", mThisStock.CardType);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CardNo", mThisStock.CardNo);
            DB.AddParameter("@CardDescription", mThisStock.CardDescription);
            DB.AddParameter("@CardType", mThisStock.CardType);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Available);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            return DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CardNo", mThisStock.CardNo);
            DB.Execute("sproc_tblStock_Delete");

        }

        public void ReportByCardType(string CardType)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CardType", CardType);
            DB.Execute("sproc_tblStock_FilterByCardType");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //clsDataConnection DB = new clsDataConnection();
            //DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {

                clsStock AnStock = new clsStock();
                AnStock.CardNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CardNo"]);
                AnStock.CardDescription = Convert.ToString(DB.DataTable.Rows[Index]["CardDescription"]);
                AnStock.CardType = Convert.ToString(DB.DataTable.Rows[Index]["CardType"]);
                AnStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                mStockList.Add(AnStock);
                Index++;
            }
        }
    }
}
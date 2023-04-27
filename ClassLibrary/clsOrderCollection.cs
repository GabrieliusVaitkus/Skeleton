using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();


        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }

        public List<clsOrder> OrderList { get { return mOrderList; } set { mOrderList = value; } }
        public int Count { get { return mOrderList.Count; } set { } }
        public clsOrder ThisOrder { get { return mThisOrder; } set { mThisOrder = value; } }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@Delivered", mThisOrder.Delivered);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@Delivered", mThisOrder.Delivered);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.Execute("sproc_tblOrder_Delete");
            
        }

        public void ReportByDeliveryAddress(string DeliveryAddress)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DeliveryAddress", DeliveryAddress);
            DB.Execute("sproc_tblOrder_FilterByDeliveryAddress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                AnOrder.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.Delivered = Convert.ToBoolean(DB.DataTable.Rows[Index]["Delivered"]);

                mOrderList.Add(AnOrder);
                Index++;

            }

        }
    }
}
using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderNo;
        private DateTime mOrderDate;
        private String mDeliveryAddress;
        private decimal mTotalPrice;
        private int mQuantity;
        private bool mDelivered;

        public bool Delivered { get { return mDelivered; } set { mDelivered = value; } }
        public int Quantity { get { return mQuantity; } set { mQuantity = value; } }
        public DateTime OrderDate { get { return mOrderDate; } set { mOrderDate = value; } }
        public Int32 OrderNo { get { return mOrderNo; } set { mOrderNo = value; } }
        public string DeliveryAddress { get { return mDeliveryAddress; } set { mDeliveryAddress = value; } }
        public decimal TotalPrice { get { return mTotalPrice; } set { mTotalPrice = value; } }

        public bool Find(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            // if one record is found (will be one or zero)
            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                return true;

            }
            // if no record is found
            else { return false; }

        }

        public string Valid(string quantity, string orderDate, string deliveryAddress, string totalPrice)
        {
            String Error = "";
            // temp var for dates
            DateTime DateTemp;
            if (deliveryAddress.Length == 0)
            {
                Error = Error + "The Delivery address may not be blank: ";
            }

            // OrderDate validate
            try
            {
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch { Error = Error + "The date is not a valid date: "; }
            return Error;
        }
    }
}
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

        public bool Find(int orderNo)
        {
            mOrderNo = 1;
            mOrderDate = Convert.ToDateTime("31/01/2023");
            mDeliveryAddress = "96 alan road";
            mTotalPrice = Convert.ToDecimal(8.99);
            mQuantity = 5;
            mDelivered = true;
            return true;
        }
    }
}
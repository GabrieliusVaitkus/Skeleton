using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderNo;
        public bool Delivered { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public Int32 OrderNo { get { return mOrderNo; } set { mOrderNo = value; } }
        public string DeliveryAddress { get; set; }
        public decimal TotalPrice { get; set; }

        public bool Find(int orderNo)
        {
            mOrderNo = 1;
            return true;
        }
    }
}
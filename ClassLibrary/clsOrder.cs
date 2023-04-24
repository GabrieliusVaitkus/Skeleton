using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Delivered { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNo { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        public clsOrderCollection()
        {
            clsOrder TestItem = new clsOrder();
            //set the properties
            TestItem.OrderNo = 1;
            TestItem.Delivered = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryAddress = "aa";
            TestItem.TotalPrice = new decimal(8.2);
            TestItem.Quantity = 5;
            mOrderList.Add(TestItem);

            // re initialise object for some new data
            TestItem = new clsOrder();

            //set the properties
            TestItem.OrderNo = 2;
            TestItem.Delivered = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryAddress = "aa";
            TestItem.TotalPrice = new decimal(9.8);
            TestItem.Quantity = 7;
            mOrderList.Add(TestItem);
        }

        public List<clsOrder> OrderList { get { return mOrderList; } set { mOrderList = value; } }
        public int Count { get { return mOrderList.Count; } set { } }
        public clsOrder ThisOrder { get; set; }
    }
}
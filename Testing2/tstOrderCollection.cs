using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOk()
        {
            //instance of class being created
            clsOrderCollection AllOrders = new clsOrderCollection();
            // data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add item to the list
            clsOrder TestItem = new clsOrder();
            //set the properties
            TestItem.Delivered = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryAddress = "aa";
            TestItem.TotalPrice = new decimal(8.2);
            TestItem.Quantity = 5;

            //add the item to the test list
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //instance of class being created
            clsOrderCollection AllOrders = new clsOrderCollection();
            // data needs to be a list of objects
            //add item to the list
            clsOrder TestOrder = new clsOrder();
            //set the properties
            TestOrder.Delivered = true;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.DeliveryAddress = "aa";
            TestOrder.TotalPrice = new decimal(8.2);
            TestOrder.Quantity = 5;

            //add the item to the test list

            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            //set the properties
            TestItem.Delivered = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryAddress = "aa";
            TestItem.TotalPrice = new decimal(8.2);
            TestItem.Quantity = 5;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Delivered = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryAddress = "aa";
            TestItem.TotalPrice = new decimal(8.2);
            TestItem.Quantity = 5;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Delivered = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryAddress = "aa";
            TestItem.TotalPrice = new decimal(8.2);
            TestItem.Quantity = 5;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            //set the updated properties
            TestItem.Delivered = false;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryAddress = "another road";
            TestItem.TotalPrice = new decimal(1.0);
            TestItem.Quantity = 9;
            // set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            // updates
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Delivered = true;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DeliveryAddress = "aa";
            TestItem.TotalPrice = new decimal(8.2);
            TestItem.Quantity = 5;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
    }
}

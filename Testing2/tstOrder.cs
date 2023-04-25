using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOk()
        {
            // tests to see if initialising class exists and works
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderNoOk()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderNo = 1;
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void DeliveredOk()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Delivered = TestData;
            Assert.AreEqual(AnOrder.Delivered, TestData);
        }

        [TestMethod]
        public void QuantityOk()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 5;
            AnOrder.Quantity = TestData;
            Assert.AreEqual(AnOrder.Quantity, TestData);

        }
        [TestMethod]
        public void DeliveryAddressOk()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "69 window road";
            AnOrder.DeliveryAddress = TestData;
            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);

        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the Item
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the item
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void TotalPriceOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the Item
            decimal TestData = new decimal(4.2);
            //Assign the data to the item
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the results of validation
            Boolean Found = false;
            // test data to find the OrderNO
            Int32 OrderNo = 8;
            Found = AnOrder.Find(OrderNo);
            // test to see if it is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the results of validation
            Boolean Found = false;
            // boolean if data is ok
            Boolean OK = true;
            Int32 OrderNo = 8;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderNo != OrderNo)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the results of validation
            Boolean Found = false;
            // boolean if data is ok
            Boolean OK = true;
            Int32 OrderNo = 8;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.OrderDate != Convert.ToDateTime("12/04/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryAddress()
        {
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the results of validation
            Boolean Found = false;
            // boolean if data is ok
            Boolean OK = true;
            Int32 OrderNo = 8;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.DeliveryAddress != "1 wow road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPrice()
        {
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the results of validation
            Boolean Found = false;
            // boolean if data is ok
            Boolean OK = true;
            Int32 OrderNo = 8;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.TotalPrice != Convert.ToDecimal(5.2))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantity()
        {
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the results of validation
            Boolean Found = false;
            // boolean if data is ok
            Boolean OK = true;
            Int32 OrderNo = 8;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.Quantity != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDelivered()
        {
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the results of validation
            Boolean Found = false;
            // boolean if data is ok
            Boolean OK = true;
            Int32 OrderNo = 8;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.Delivered != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}

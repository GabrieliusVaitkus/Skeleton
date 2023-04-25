using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        // good test data
        string Quantity = "5";
        string OrderDate = Convert.ToString(DateTime.Now.Date);
        string DeliveryAddress = "Leicester";
        string TotalPrice = "8.2";

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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            // string to store error message
            String Error = "";
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            // string to store error message
            String Error = "";
            string DeliveryAddress = "a";
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            // string to store error message
            String Error = "";
            string DeliveryAddress = "aa";
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            // string to store error message
            String Error = "";
            string DeliveryAddress = "";
            DeliveryAddress.PadRight(257, 'a'); // should fail
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            DateTime TestDate;
            //date is todays date
            TestDate = DateTime.Now.Date;
            //The date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert date to a string
            string OrderDate = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            DateTime TestDate;
            //date is todays date
            TestDate = DateTime.Now.Date;
            //The date minus 100 years
            TestDate = TestDate.AddDays(-1);
            //convert date to a string
            string OrderDate = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            DateTime TestDate;
            //date is todays date
            TestDate = DateTime.Now.Date;

            //convert date to a string
            string OrderDate = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            DateTime TestDate;
            //date is todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            //convert date to a string
            string OrderDate = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            DateTime TestDate;
            //date is todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            //convert date to a string
            string OrderDate = TestDate.ToString();
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string OrderDate = "imma not a date";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string Quantity = "one hundred";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string Quantity = "0";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string Quantity = "-1";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string Quantity = "1";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        // totalPrice validate
        [TestMethod]
        public void TotalPriceInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string TotalPrice = "one hundred pounds";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void TotalPriceMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string TotalPrice = "0.0";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string TotalPrice = "-1.1";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //a variable to store test date data
            string TotalPrice = "1";
            //invoke method
            Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
            Assert.AreEqual(Error, "");
        }
    }
}
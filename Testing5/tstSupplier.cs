using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        //test date to make sure it can pass
        string supplierName = "alibaba";
        string supplierContactNo = "07856162654";
        string supplierEmail = "alibaba54@gmail.com";
        string supplierAddress = "24 shipton road, NN10 9BE";
        string dateRegistered = DateTime.Now.Date.ToString();

        [TestMethod]
        public void SupplierNoOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 1;
            ASupplier.supplierNo = TestData;
            Assert.AreEqual(ASupplier.supplierNo, TestData);
        }
        [TestMethod]
        public void SupplierNameOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "alibaba";
            ASupplier.supplierName = TestData;
            Assert.AreEqual(ASupplier.supplierName, TestData);
        }
        [TestMethod]
        public void SupplierContactNoOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "07856162654";
            ASupplier.supplierContactNo = TestData;
            Assert.AreEqual(ASupplier.supplierContactNo, TestData);
        }
        [TestMethod]
        public void SupplierEmailOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "alibaba54@gmail.com";
            ASupplier.supplierEmail = TestData;
            Assert.AreEqual(ASupplier.supplierEmail, TestData);
        }
        [TestMethod]
        public void SupplierAddressOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "24 shipton road, NN10 9BE";
            ASupplier.supplierAddress = TestData;
            Assert.AreEqual(ASupplier.supplierAddress, TestData);
        }
        [TestMethod]
        public void DateRegisteredOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.dateRegistered = TestData;
            Assert.AreEqual(ASupplier.dateRegistered, TestData);
        }
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of Supplier class
            clsSupplier ASupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(ASupplier);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Int32 supplierNo = 1;
            Found = ASupplier.Find(supplierNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierNoFound()
        {
            //instance of class being created 
            clsSupplier ASupplier = new clsSupplier();
            //boolean variabel to store result of search
            Boolean Found = false;
            //record if data is OK
            Boolean OK = true;
            //create test data to use with the method
            Int32 supplierNo = 1;
            //Invoke method
            Found = ASupplier.Find(supplierNo);
            // check customer number
            if (ASupplier.supplierNo != 1)
            {
                OK = false;
            }
            //test to see that the result is ok/correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 supplierNo = 1;
            Found = ASupplier.Find(supplierNo);
            if (ASupplier.supplierName != "alibaba")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierContactNoFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 supplierNo = 1;
            Found = ASupplier.Find(supplierNo);
            if (ASupplier.supplierContactNo != "07856162654")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierEmailFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 supplierNo = 1;
            Found = ASupplier.Find(supplierNo);
            if (ASupplier.supplierEmail != "alibaba54@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierAddressFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 supplierNo = 1;
            Found = ASupplier.Find(supplierNo);
            if (ASupplier.supplierAddress != "24 shipton road, NN10 9BE")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateRegisteredFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 supplierNo = 1;
            //imvoke the method
            Found = ASupplier.Find(supplierNo);
            if (ASupplier.dateRegistered != Convert.ToDateTime("20/02/2022"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 supplierNo = 1;
            Found = ASupplier.Find(supplierNo);
            if (ASupplier.active != true)
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //instance of class
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store error message
            String Error = "";
            //invoke method
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierName = "";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierName = "a";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierName = "aa";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierName = "";
            supplierName = supplierName.PadRight(500, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "a";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "aa";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "";
            supplierAddress = supplierAddress.PadRight(49, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "";
            supplierAddress = supplierAddress.PadRight(50, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "";
            supplierAddress = supplierAddress.PadRight(51, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "";
            supplierAddress = supplierAddress.PadRight(25, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierAddress = "";
            supplierAddress = supplierAddress.PadRight(500, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "a";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "aa";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(25, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(50, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(49, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(51, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierEmail = "";
            supplierEmail = supplierEmail.PadRight(500, 'a');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactNoMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierContactNo = "";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactNoMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierContactNo = "1";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactNoMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierContactNo = "11";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactNoMid()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierContactNo = "111";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactNoMaxLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierContactNo = "";
            supplierContactNo = supplierContactNo.PadRight(49, '1');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactNoMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierContactNo = "";
            supplierContactNo = supplierContactNo.PadRight(50, '1');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactNoMaxPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierContactNo = "";
            supplierContactNo = supplierContactNo.PadRight(51, '1');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierContactNoExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string supplierContactNo = "";
            supplierContactNo = supplierContactNo.PadRight(500, '1');
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        public void DateRegisteredExtremeMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            //a variable to store test date data
            DateTime TestDate;
            //date is todays date
            TestDate = DateTime.Now.Date;
            //The date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert date to a string
            string dateRegistered = TestDate.ToString();
            //invoke method
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateRegisteredMinLessOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string dateRegistered = TestDate.ToString();
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void DateRegisteredMin()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string dateRegistered = TestDate.ToString();
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateRegisteredMinPlusOne()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string dateRegistered = TestDate.ToString();
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateRegisteredExtremeMax()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string dateRegistered = TestDate.ToString();
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredInvalidData()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            string dateRegistered = "This is not a date!";
            Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);
            Assert.AreNotEqual(Error, "");
        }

    }
}
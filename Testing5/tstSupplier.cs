using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
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
        public void ActiveOK()
        {
            //create an instance of Customer class
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
            Assert.IsTrue(OK);
        }

    }
}

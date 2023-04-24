using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOk()
        {
            //instance of class being created
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            // data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add item to the list
            clsCustomer TestItem = new clsCustomer();
            //set the properties
            TestItem.AccountActive = true;
            TestItem.CustomerNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FirstName = "aa";
            TestItem.LastName = "aa";
            TestItem.ContactNumber = "1234";
            TestItem.Email = "sdsds@dsds";
            //add the item to the test list
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            // instance of class created
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Some test data to assign to property
            Int32 SomeCount = 2;
            //assign date to property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //creation of an instance of class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data to assign the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object, can copy previous 
            TestCustomer.AccountActive = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.DateAdded = DateTime.Now.Date;
            TestCustomer.FirstName = "aa";
            TestCustomer.LastName = "aa";
            TestCustomer.ContactNumber = "1234";
            TestCustomer.Email = "sdsds@dsds";
            //assign the data to property
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.AccountActive = true;
            TestItem.CustomerNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FirstName = "aa";
            TestItem.LastName = "aa";
            TestItem.ContactNumber = "1234";
            TestItem.Email = "sdsds@dsds";
            //add the item to the test list
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.AreEqual(AllCustomers.Count, 2);
        }


    }
}


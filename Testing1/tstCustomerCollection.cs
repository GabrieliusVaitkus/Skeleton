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
            TestItem.PhoneNo = "1234";
            TestItem.Email = "sdsds@dsds";
            //add the item to the test list
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
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
            TestCustomer.PhoneNo = "1234";
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
            clsCustomer TestItem = new  clsCustomer();
            TestItem.AccountActive = true;
            TestItem.CustomerNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FirstName = "aa";
            TestItem.LastName = "aa";
            TestItem.PhoneNo = "1234";
            TestItem.Email = "sdsds@dsds";
            //add the item to the test list
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }
        [TestMethod] 
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.AccountActive = true;
            TestItem.CustomerNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FirstName = "aa";
            TestItem.LastName = "aa";
            TestItem.PhoneNo = "1234";
            TestItem.Email = "sdsds@dsds";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerNo = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        //[TestMethod]
        //public void UpdateMethodOK()
        //{
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    clsCustomer TestItem = new clsCustomer();
        //    Int32 PrimaryKey = 0;
        //    TestItem.AccountActive = true;
        //    TestItem.CustomerNo = 1;
        //    TestItem.DateAdded = DateTime.Now.Date;
        //    TestItem.FirstName = "aa";
        //    TestItem.LastName = "aa";
        //    TestItem.PhoneNo = "1234";
        //    TestItem.Email = "sdsds@dsds";
        //    AllCustomers.ThisCustomer = TestItem;
        //    PrimaryKey = AllCustomers.Add();
        //    TestItem.CustomerNo = PrimaryKey;
        //    TestItem.AccountActive = true;
        //    TestItem.CustomerNo = 3;
        //    TestItem.DateAdded = DateTime.Now.Date;
        //    TestItem.FirstName = "bb";
        //    TestItem.LastName = "bb";
        //    TestItem.PhoneNo = "1456";
        //    TestItem.Email = "abcd@ghji.com";
        //    AllCustomers.ThisCustomer = TestItem;
        //    AllCustomers.Update();
        //    AllCustomers.ThisCustomer.Find(PrimaryKey);
        //    Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        //}
    }
}


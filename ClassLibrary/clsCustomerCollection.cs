using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection


    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public clsCustomerCollection()
        {
            clsCustomer TestItem = new clsCustomer();
            TestItem.AccountActive = true;
            TestItem.CustomerNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FirstName = "aa";
            TestItem.LastName = "aa";
            TestItem.ContactNumber = "1234";
            TestItem.Email = "sdsds@dsds";
            mCustomerList.Add(TestItem);
            TestItem = new clsCustomer();
            TestItem.AccountActive = true;
            TestItem.CustomerNo = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FirstName = "bb";
            TestItem.LastName = "bb";
            TestItem.ContactNumber = "2345";
            TestItem.Email = "asdf@gfd";
            mCustomerList.Add(TestItem);
        }

        //private data member for the list

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }

            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        { 
            //return the count of the list
            get
            {
                //return the count of the list
                return mCustomerList.Count;

            }
            set
            {
                //worry about this last
            }
        
        }
        public clsCustomer ThisCustomer { get; set; }
        //public clsCustomerCollection()
        //{
        //    clsCustomer TestItem = new clsCustomer();
        //    TestItem.AccountActive = true;
        //    TestItem.CustomerNo = 1;
        //    TestItem.DateAdded = DateTime.Now.Date;
        //    TestItem.FirstName = "aa";
        //    TestItem.LastName = "aa";
        //    TestItem.ContactNumber = "1234";
        //    TestItem.Email = "sdsds@dsds";
        //    mCustomerList.Add(TestItem);
        //    TestItem = new clsCustomer();
        //    TestItem.AccountActive = true;
        //    TestItem.CustomerNo = 2;
        //    TestItem.DateAdded = DateTime.Now.Date;
        //    TestItem.FirstName = "bb";
        //    TestItem.LastName = "bb";
        //    TestItem.ContactNumber = "2345";
        //    TestItem.Email = "asdf@gfd";
        //    mCustomerList.Add(TestItem);
        //}
    }

}

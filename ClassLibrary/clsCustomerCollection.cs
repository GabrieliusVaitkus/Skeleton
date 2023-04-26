using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection


    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in field from current record
                ACustomer.AccountActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountActive"]);
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
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

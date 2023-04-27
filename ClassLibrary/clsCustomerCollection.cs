using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection


    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

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
                ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
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
        public clsCustomer ThisCustomer
        {
        get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("AccountActive", mThisCustomer.AccountActive);
            return DB.Execute("sproc_tblCustomer_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("AccountActive", mThisCustomer.AccountActive);
            DB.Execute("sproc_tblCustomer_Update");

        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", FirstName);
            DB.Execute("sproc_tblCustomer_FilterByFirstName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.AccountActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountActive"]);
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                mCustomerList.Add(ACustomer);
                
                Index++;
            }
        }
    }

}

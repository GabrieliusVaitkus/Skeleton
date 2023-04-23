using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);

        }
        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }

            set
            {
                mSupplierList = value;
            }
        }

        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }

            set
            {

            }
        }

        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }

            set
            {
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierName", mThisSupplier.supplierName);
            DB.AddParameter("@supplierContactNo", mThisSupplier.supplierContactNo);
            DB.AddParameter("@supplierEmail", mThisSupplier.supplierEmail);
            DB.AddParameter("@supplierAddress", mThisSupplier.supplierAddress);
            DB.AddParameter("@dateRegistered", mThisSupplier.dateRegistered);
            DB.AddParameter("@active", mThisSupplier.active);
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierName", mThisSupplier.supplierName);
            DB.AddParameter("@supplierContactNo", mThisSupplier.supplierContactNo);
            DB.AddParameter("@supplierEmail", mThisSupplier.supplierEmail);
            DB.AddParameter("@supplierAddress", mThisSupplier.supplierAddress);
            DB.AddParameter("@dateRegistered", mThisSupplier.dateRegistered);
            DB.AddParameter("@active", mThisSupplier.active);
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierNo", mThisSupplier.supplierNo);
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportBysupplierName(string supplierName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierName", supplierName);
            DB.Execute("sproc_tblSupplier_FilterBySupplierName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();

                ASupplier.supplierNo = Convert.ToInt32(DB.DataTable.Rows[Index]["supplierNo"]);
                ASupplier.supplierName = Convert.ToString(DB.DataTable.Rows[Index]["supplierName"]);
                ASupplier.supplierContactNo = Convert.ToString(DB.DataTable.Rows[Index]["supplierContactNo"]);
                ASupplier.supplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["supplierEmail"]);
                ASupplier.supplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["supplierAddress"]);
                ASupplier.dateRegistered = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateRegistered"]);
                ASupplier.active = Convert.ToBoolean(DB.DataTable.Rows[Index]["active"]);

                mSupplierList.Add(ASupplier);
                Index++;
            }
        }
    }
}
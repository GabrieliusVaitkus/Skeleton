using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }

            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }

            set
            {

            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }

            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffName", mThisStaff.staffName);
            DB.AddParameter("@staffAddress", mThisStaff.staffAddress);
            DB.AddParameter("@staffMoNumber", mThisStaff.staffMoNumber);
            DB.AddParameter("@staffRole", mThisStaff.staffRole);
            DB.AddParameter("@staffDateAdded", mThisStaff.staffDateAdded);
            DB.AddParameter("@staffActive", mThisStaff.staffActive);
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffName", mThisStaff.staffName);
            DB.AddParameter("@staffAddress", mThisStaff.staffAddress);
            DB.AddParameter("@staffMoNumber", mThisStaff.staffMoNumber);
            DB.AddParameter("@staffRole", mThisStaff.staffRole);
            DB.AddParameter("@staffDateAdded", mThisStaff.staffDateAdded);
            DB.AddParameter("@staffActive", mThisStaff.staffActive);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffNo", mThisStaff.staffNo);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffRole(string staffRole)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffRole", staffRole);
            DB.Execute("sproc_tblStaff_FilterByStaffRole");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();

                AnStaff.staffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["staffNo"]);
                AnStaff.staffAddress = Convert.ToString(DB.DataTable.Rows[Index]["staffAddress"]);
                AnStaff.staffActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["staffActive"]);
                AnStaff.staffDateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["staffDateAdded"]);
                AnStaff.staffMoNumber = Convert.ToString(DB.DataTable.Rows[Index]["staffMoNumber"]);
                AnStaff.staffName = Convert.ToString(DB.DataTable.Rows[Index]["staffName"]);
                AnStaff.staffRole = Convert.ToString(DB.DataTable.Rows[Index]["staffRole"]);

                mStaffList.Add(AnStaff);
                Index++;
            }
        }
    }
}
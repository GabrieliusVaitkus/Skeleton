using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 msupplierNo;
        public Int32 supplierNo
        {
            get
            {
                return msupplierNo;
            }
            set
            {
                msupplierNo = value;

            }
        }

        private string msupplierName;
        public string supplierName
        {
            get
            {
                return msupplierName;
            }
            set
            {
                msupplierName = value;
            }
        }

        private string msupplierContactNo;
        public string supplierContactNo
        {
            get
            {
                return msupplierContactNo;
            }
            set
            {
                msupplierContactNo = value;
            }
        }
        private string msupplierEmail;
        public string supplierEmail
        {
            get
            {
                return msupplierEmail;
            }
            set
            {
                msupplierEmail = value;
            }
        }

        private string msupplierAddress;
        public string supplierAddress
        {
            get
            {
                return msupplierAddress;
            }
            set
            {
                msupplierAddress = value;
            }
        }

        private DateTime mdateRegistered;
        public DateTime dateRegistered

        {
            get
            {
                return mdateRegistered;

            }
            set
            {
                mdateRegistered = value;
            }
        }

        private bool mactive;
        public bool active
        {
            get
            {
                return mactive;
            }
            set
            {
                mactive = value;
            }
        }
        public bool Find(int supplierNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@supplierNo", supplierNo);
            DB.Execute("sproc_tblSupplier_FilterBySupplierNo");
            if (DB.Count == 1)


            {
                //set the privare data members to the test data value
                msupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["supplierNo"]);
                msupplierName = Convert.ToString(DB.DataTable.Rows[0]["supplierName"]);
                msupplierContactNo = Convert.ToString(DB.DataTable.Rows[0]["supplierContactNo"]);
                msupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["supplierEmail"]);
                msupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["supplierAddress"]);
                mdateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["dateRegistered"]);
                mactive = Convert.ToBoolean(DB.DataTable.Rows[0]["active"]);

                //always return true
                return true;
            }
            else
            {

                return false;
            }
        }

        public string Valid(string supplierName, string supplierContactNo, string supplierEmail, string supplierAddress, string dateRegistered)
        {
            String Error = "";

            DateTime DateTemp;

            if (supplierName.Length == 0)
            {
                Error = Error + "Supplier Name may not be blank : ";
            }

            if (supplierContactNo.Length == 0)
            {
                Error = Error + "Supplier Contact Number may not be blank : ";
            }

            if (supplierEmail.Length == 0)
            {
                Error = Error + "Supplier Email may not be blank : ";
            }

            if (supplierName.Length > 50)
            {
                Error = Error + "Supplier Name must be less than 50 characters : ";
            }

            if (supplierAddress.Length > 50)
            {
                Error = Error + "Supplier Address must be less than 50 characters : ";
            }

            if (supplierContactNo.Length > 50)
            {
                Error = Error + "Supplier Contact Number must be less than 50 characters : ";
            }

            if (supplierAddress.Length == 0)
            {
                Error = Error + "Supplier Address may not be blank : ";
            }

            if (supplierEmail.Length > 50)
            {
                Error = Error + "Supplier Email must be less than 50 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateRegistered);

                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }

            catch
            {
                Error = Error + "The date was not a valid date : ";
            }


            return Error;
        }
    }
}

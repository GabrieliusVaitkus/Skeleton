using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
       

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
    }
}

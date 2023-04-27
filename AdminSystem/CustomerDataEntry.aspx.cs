using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
    
{
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
            if(CustomerNo != -1)
            {
                DisplayCustomer();
            }
        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomerNo = new clsCustomer();
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string PhoneNo = txtContactNumber.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = ACustomerNo.Valid(FirstName, LastName, Email, PhoneNo, DateAdded);
        if (Error == "")

        {
            ACustomerNo.CustomerNo = CustomerNo;
            ACustomerNo.FirstName = FirstName;
            ACustomerNo.LastName = LastName;
            ACustomerNo.Email = Email;
            ACustomerNo.PhoneNo = PhoneNo;
            ACustomerNo.DateAdded = Convert.ToDateTime(DateAdded);
            ACustomerNo.AccountActive = chkActive.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //CustomerList.ThisCustomer = ACustomerNo;
            //CustomerList.Add();
            //Response.Redirect("CustomerList.aspx");
            if (CustomerNo == -1)
            {
                CustomerList.ThisCustomer = ACustomerNo;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerNo);
                CustomerList.ThisCustomer = ACustomerNo;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomerNo = new clsCustomer();
        Int32 CustomerNo;
        Boolean Found = false;
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        Found = ACustomerNo.Find(CustomerNo);
        if (Found == true)
        {
            txtFirstName.Text = ACustomerNo.FirstName;
            txtLastName.Text = ACustomerNo.LastName;
            txtEmail.Text = ACustomerNo.Email;
            txtContactNumber.Text = ACustomerNo.PhoneNo;
            txtDateAdded.Text = ACustomerNo.DateAdded.ToString();
            chkActive.Checked = ACustomerNo.AccountActive;
        }
    }
    void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerNo);
        txtCustomerNo.Text = CustomerBook.ThisCustomer.CustomerNo.ToString();
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
        txtLastName.Text = CustomerBook.ThisCustomer.LastName;
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        txtContactNumber.Text = CustomerBook.ThisCustomer.PhoneNo;
        txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
        chkActive.Checked = CustomerBook.ThisCustomer.AccountActive;
    }




    
}
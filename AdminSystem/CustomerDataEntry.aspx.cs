using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string PhoneNo = txtContactNumber.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = ACustomer.Valid(LastName, Email, PhoneNo, DateAdded, FirstName);
        if (Error == "")
        {
            ACustomer.FirstName = FirstName;
            ACustomer.LastName = LastName;
            ACustomer.Email = Email;
            ACustomer.PhoneNo = PhoneNo;
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            Session["ACustomer"] = ACustomer;
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
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
            ACustomerNo.FirstName = FirstName;
            ACustomerNo.LastName = LastName;
            ACustomerNo.Email = Email;
            ACustomerNo.PhoneNo = PhoneNo;
            ACustomerNo.DateAdded = Convert.ToDateTime(DateAdded);
            ACustomerNo.AccountActive = chkActive.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = ACustomerNo;
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");       
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void txtCPhoneNo_TextChanged(object sender, EventArgs e)
    {

    }
}
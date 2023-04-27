using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomer();
        }

    }
    void DisplayCustomer()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerNo"] = -1;
        Response.Redirect("CustomerDataEntry.apsx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerNo"] = CustomerNo;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;
        if(lstCustomerList.SelectedIndex != 1)
        {
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustoemrNo"] = CustomerNo;
            Response.Redirect("CustomerConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = " Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByFirstName(txtEnterAFirstName.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByFirstName("");
        txtEnterAFirstName.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "FirstName";
        lstCustomerList.DataBind();
    }
}
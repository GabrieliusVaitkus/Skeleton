using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 supplierNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        supplierNo = Convert.ToInt32(Session["supplierNo"]);
        if (IsPostBack == false)
        {
            if (supplierNo != -1)
            {
                DisplaySupplier();
            }
        }

    }

    private void DisplaySupplier()
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        SupplierBook.ThisSupplier.Find(supplierNo);
        txtSupplierNo.Text = SupplierBook.ThisSupplier.supplierNo.ToString();
        txtSupplierName.Text = SupplierBook.ThisSupplier.supplierName;
        txtSupplierContactNo.Text = SupplierBook.ThisSupplier.supplierContactNo;
        txtSupplierEmail.Text = SupplierBook.ThisSupplier.supplierEmail;
        txtSupplierAddress.Text = SupplierBook.ThisSupplier.supplierAddress;
        txtDateRegistered.Text = SupplierBook.ThisSupplier.dateRegistered.ToString();
        chkActive.Checked = SupplierBook.ThisSupplier.active;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //New instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();

        //Capture the name
        string supplierName = txtSupplierName.Text;
        string supplierContactNo = txtSupplierContactNo.Text;
        string supplierEmail = txtSupplierEmail.Text;
        string supplierAddress = txtSupplierAddress.Text;
        string dateRegistered = txtDateRegistered.Text;

        string Error = "";
        Error = ASupplier.Valid(supplierName, supplierContactNo, supplierEmail, supplierAddress, dateRegistered);

        if (Error == "")
        {
            ASupplier.supplierNo = supplierNo;
            ASupplier.supplierName = supplierName;
            ASupplier.supplierContactNo = supplierContactNo;
            ASupplier.supplierEmail = supplierEmail;
            ASupplier.supplierAddress = supplierAddress;
            ASupplier.dateRegistered = Convert.ToDateTime(dateRegistered);

            clsSupplierCollection SupplierList = new clsSupplierCollection();
            SupplierList.ThisSupplier = ASupplier;
            SupplierList.Add();

            Response.Redirect("SupplierList.aspx");

            if (supplierNo == -1)
            {
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Add();
            }

            else
            {
                SupplierList.ThisSupplier.Find(supplierNo);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();
            }

            Response.Redirect("SupplierList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsSupplier ASupplier = new clsSupplier();
        //variable to store the primary key
        Int32 supplierNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        supplierNo = Convert.ToInt32(txtSupplierNo.Text);
        //find the record
        Found = ASupplier.Find(supplierNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplierName.Text = ASupplier.supplierName;
            txtSupplierContactNo.Text = ASupplier.supplierContactNo.ToString();
            txtSupplierEmail.Text = ASupplier.supplierEmail;
            txtSupplierAddress.Text = ASupplier.supplierAddress;
            txtDateRegistered.Text = ASupplier.dateRegistered.ToString();
            chkActive.Checked = ASupplier.active;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}
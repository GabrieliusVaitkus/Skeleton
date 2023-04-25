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
            DisplaySupplier();
        }
    }

    void DisplaySupplier()
    {
        clsSupplierCollection AllSupplier = new clsSupplierCollection();
        lstSupplierList.DataSource = AllSupplier.SupplierList;
        lstSupplierList.DataValueField = "supplierNo";
        lstSupplierList.DataTextField = "supplierName";
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["supplierNo"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 supplierNo;
        if (lstSupplierList.SelectedIndex != -1)
        {
            supplierNo = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["supplierNo"] = supplierNo;
            Response.Redirect("SupplierDataEntry.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 supplierNo;
        if (lstSupplierList.SelectedIndex != -1)
        {
            supplierNo = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["supplierNo"] = supplierNo;
            Response.Redirect("SupplierConfirmDelete.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsSupplierCollection AllSupplier = new clsSupplierCollection();
        AllSupplier.ReportBysupplierName(txtFilter.Text);
        lstSupplierList.DataSource = AllSupplier.SupplierList;
        lstSupplierList.DataValueField = "supplierNo";
        lstSupplierList.DataTextField = "supplierName";
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsSupplierCollection AllSupplier = new clsSupplierCollection();
        AllSupplier.ReportBysupplierName("");
        txtFilter.Text = "";
        lstSupplierList.DataSource = AllSupplier.SupplierList;
        lstSupplierList.DataValueField = "supplierNo";
        lstSupplierList.DataTextField = "supplierName";
        lstSupplierList.DataBind();
    }
}
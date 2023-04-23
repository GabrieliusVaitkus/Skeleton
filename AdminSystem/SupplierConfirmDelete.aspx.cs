using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 supplierNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        supplierNo = Convert.ToInt32(Session["supplierNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        SupplierBook.ThisSupplier.Find(supplierNo);
        SupplierBook.Delete();
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}
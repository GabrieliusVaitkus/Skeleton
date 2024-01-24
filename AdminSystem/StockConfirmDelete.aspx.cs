using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CardNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CardNo = Convert.ToInt32(Session["CardNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(CardNo);
        StockBook.Delete();
        Response.Redirect("StockBookList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockBookList.aspx");

    }
}
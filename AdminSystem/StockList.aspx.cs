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
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        clsStockCollection Stocks = new clsStockCollection();
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "CardNo";
        lstStockList.DataTextField = "CardType";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockNo"] = -1;
        Response.Redirect("StockDataEntry");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CardNo;
        if (lstStockList.SelectedIndex != -1)
        {
            CardNo = Convert.ToInt32(lstStockList.SelectedIndex);
            Session["CardNo"] = CardNo;
            Response.Redirect("StockBookDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CardNo;
        if (lstStockList.SelectedIndex != -1)
        {
            CardNo = Convert.ToInt32(lstStockList.SelectedValue);
            Session["CardNo"] = CardNo;
            Response.Redirect("StockBookConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
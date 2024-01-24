using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CardNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CardNo = Convert.ToInt32(Session["CardNo"]);
        if (IsPostBack == false)
        {
            if (CardNo != -1)
            {
                DisplayStock();
            }
        }

    }

    private void DisplayStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(CardNo);


        txtCardNo.Text = StockBook.ThisStock.CardNo.ToString();
        txtCardDescription.Text = StockBook.ThisStock.CardDescription;
        txtCardType.Text = StockBook.ThisStock.CardType;
        txtPrice.Text = Convert.ToString(StockBook.ThisStock.Price);
        txtDateAdded.Text = StockBook.ThisStock.DateAdded.ToString();
        chkAvailable.Checked = StockBook.ThisStock.Available;

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtAvailable_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        string CardDescription = txtCardDescription.Text;
        string Price = txtPrice.Text;
        string CardType = txtCardType.Text;
        string DateAdded = txtDateAdded.Text;

        string Error = "";
        Error = AnStock.Valid(Price, CardDescription, CardType, DateAdded);

        if (Error == "")
        {
            AnStock.Available = chkAvailable.Checked; ;
            AnStock.CardDescription = CardDescription;
            AnStock.CardType = CardType;
            AnStock.Price = Convert.ToDecimal(Price);
            AnStock.DateAdded = Convert.ToDateTime(DateAdded);
            clsStockCollection StockList = new clsStockCollection();
            
            if (CardNo == -1)
            {
                StockList.ThisStock = AnStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(CardNo);
                StockList.ThisStock = AnStock;
                StockList.Update();
            }
            Response.Redirect("StockList.aspx");


        }

        else
        {
            lblError.Text = Error;
        }
        
    }
    


    protected void txtCardNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCardType_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        Int32 CardNo;
        Boolean Found = false;
        CardNo = Convert.ToInt32(txtCardNo.Text);
        Found = AnStock.Find(CardNo);
        if (Found == true)
        {
            txtCardDescription.Text = AnStock.CardDescription;
            txtCardType.Text = AnStock.CardType;
            txtPrice.Text = Convert.ToString(AnStock.Price);
            txtDateAdded.Text = AnStock.DateAdded.ToString();
            chkAvailable.Checked = AnStock.Available;
            




        }
    }
}
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

    protected void txtAvailable_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the stock no
        AnStock.CardNo = Convert.ToInt32(txtCardNo.Text);
        



        //store the stock in the session object
        Session["AnStock"] = AnStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
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
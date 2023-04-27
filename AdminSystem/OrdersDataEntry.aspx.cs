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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        string Quantity = txtQuantity.Text;
        string OrderDate = txtOrderDate.Text;
        string DeliveryAddress = txtDeliveryAddress.Text;
        string TotalPrice = txtTotalPrice.Text;

        string Error = "";
        //validate the data
        Error = AnOrder.Valid(Quantity, OrderDate, DeliveryAddress, TotalPrice);
        if (Error == "")
        {
            //AnOrder.Quantity = Quantity;
            //AnOrder.OrderDate = OrderDate;
            //AnOrder.DeliveryAddress = DeliveryAddress;
            //AnOrder.TotalPrice = TotalPrice;
            // capture the input data

            AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
            AnOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            AnOrder.DeliveryAddress = txtDeliveryAddress.Text;
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            AnOrder.Delivered = chkDelivered.Checked;
            AnOrder.TotalPrice = (decimal)Convert.ToDouble(txtTotalPrice.Text);
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();

            //naviage to the viewer page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            // displays the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        // capture the input data
        Int32 OrderNo;
        Boolean Found = false;
        // get primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = AnOrder.Find(OrderNo);

        if (Found == true)
        {
            txtQuantity.Text = Convert.ToString(AnOrder.Quantity);
            txtDeliveryAddress.Text = AnOrder.DeliveryAddress;
            txtOrderDate.Text = Convert.ToString(AnOrder.OrderDate);
            chkDelivered.Checked = AnOrder.Delivered;
            txtTotalPrice.Text = Convert.ToString(AnOrder.TotalPrice);
            chkDelivered.Checked = AnOrder.Delivered;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of orders to be processed
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            // if it is not a new record
            if (OrderNo != -1)
            {
                DisplayOrder();
            }
        }

    }

    void DisplayOrder()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        // find the record to update
        Orders.ThisOrder.Find(OrderNo);

        // displays the data for this record
        txtOrderNo.Text = Orders.ThisOrder.OrderNo.ToString();
        txtQuantity.Text = Orders.ThisOrder.Quantity.ToString();
        txtDeliveryAddress.Text = Orders.ThisOrder.DeliveryAddress;
        txtTotalPrice.Text = Orders.ThisOrder.TotalPrice.ToString();
        txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString();
        chkDelivered.Checked = Orders.ThisOrder.Delivered;

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
            AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
            AnOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            AnOrder.DeliveryAddress = txtDeliveryAddress.Text;
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            AnOrder.Delivered = chkDelivered.Checked;
            AnOrder.TotalPrice = (decimal)Convert.ToDouble(txtTotalPrice.Text);
            clsOrderCollection OrderList = new clsOrderCollection();


            if (OrderNo == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderNo);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
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

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
        // capture the Delivery address
        AnOrder.DeliveryAddress = txtDeliveryAddress.Text;
        // store the delivery address in the session object
        Session["AnOrder"] = AnOrder;
        //naviage to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }
}


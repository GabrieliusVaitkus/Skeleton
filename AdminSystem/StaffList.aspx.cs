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
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        lstStaffList.DataSource = AllStaff.StaffList;
        lstStaffList.DataValueField = "staffNo";
        lstStaffList.DataTextField = "staffName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["staffNo"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffNo;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["staffNo"] = StaffNo;
            Response.Redirect("StaffDataEntry.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffNo;
        if (lstStaffList.SelectedIndex != 1)
        {
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["staffNo"] = StaffNo;
            Response.Redirect("StaffConfirmDelete.aspx");
        }

        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        AllStaff.ReportByStaffRole(txtFilter.Text);
        lstStaffList.DataSource = AllStaff.StaffList;
        lstStaffList.DataValueField = "staffNo";
        lstStaffList.DataTextField = "staffRole";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        AllStaff.ReportByStaffRole("");
        txtFilter.Text = "";
        lstStaffList.DataSource = AllStaff.StaffList;
        lstStaffList.DataValueField = "staffNo";
        lstStaffList.DataTextField = "staffRole";
        lstStaffList.DataBind();
    }
}
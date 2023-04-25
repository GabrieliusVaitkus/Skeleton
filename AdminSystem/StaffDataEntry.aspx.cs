using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["staffNo"]);
        if (IsPostBack == false)
        {
            if (StaffNo != -1)
            {
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffNo);
        txtStaffAddress.Text = StaffBook.ThisStaff.staffAddress;
        txtStaffDateAdded.Text = StaffBook.ThisStaff.staffDateAdded.ToString();
        txtStaffMoNumber.Text = StaffBook.ThisStaff.staffMoNumber;
        txtStaffName.Text = StaffBook.ThisStaff.staffName;
        txtStaffNo.Text = StaffBook.ThisStaff.staffNo.ToString();
        txtStaffRole.Text = StaffBook.ThisStaff.staffRole;
        chkActive.Checked = StaffBook.ThisStaff.staffActive;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //New instance of clsStaff
        clsStaff AnStaffNo = new clsStaff();

        //Capture the name
        string staffName = txtStaffName.Text;
        string staffAddress = txtStaffAddress.Text;
        string staffMoNumber = txtStaffMoNumber.Text;
        string staffRole = txtStaffRole.Text;
        string staffDateAdded = txtStaffDateAdded.Text;

        string Error = "";
        Error = AnStaffNo.Valid(staffName, staffAddress, staffMoNumber, staffRole, staffDateAdded);

        if (Error == "")
        {
            AnStaffNo.staffNo = StaffNo;
            AnStaffNo.staffName = staffName;
            AnStaffNo.staffAddress = staffAddress;
            AnStaffNo.staffMoNumber = staffMoNumber;
            AnStaffNo.staffRole = staffRole;
            AnStaffNo.staffDateAdded = Convert.ToDateTime(staffDateAdded);

            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = AnStaffNo;
            StaffList.Add();

            Response.Redirect("StaffList.aspx");

            if (StaffNo == -1)
            {
                StaffList.ThisStaff = AnStaffNo;
                StaffList.Add();
            }

            else
            {
                StaffList.ThisStaff.Find(StaffNo);
                StaffList.ThisStaff = AnStaffNo;
                StaffList.Update();
            }

            Response.Redirect("StaffList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the address class
        clsStaff AnStaffNo = new clsStaff();

        //Variable to store the primary key
        Int32 StaffNo;

        //Variable to store the result of the find operation
        Boolean Found = false;

        //Get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);

        //Find the record
        Found = AnStaffNo.Find(StaffNo);

        //If found
        if (Found == true)
        {
            //Display the values of the properties in the form
            txtStaffAddress.Text = AnStaffNo.staffAddress;
            txtStaffDateAdded.Text = AnStaffNo.staffDateAdded.ToString();
            txtStaffMoNumber.Text = AnStaffNo.staffMoNumber.ToString();
            txtStaffName.Text = AnStaffNo.staffName;
            txtStaffNo.Text = AnStaffNo.staffNo.ToString();
            txtStaffRole.Text = AnStaffNo.staffRole;
            chkActive.Checked = AnStaffNo.staffActive;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
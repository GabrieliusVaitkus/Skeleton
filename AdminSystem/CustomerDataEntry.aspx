<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number"></asp:Label>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 322px; top: 10px; position: absolute; width: 39px; margin-top: 0px;" Text="Find" />
            <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName"  runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email Adress"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblContactNumber" runat="server" Text="Contact Number"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtContactNumber" runat="server" ></asp:TextBox>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffNo" runat="server" Text="Staff Number"></asp:Label>
        <asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <asp:Label ID="lblStaffName" runat="server" Text="Staff Name" width="82px"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffAddress" runat="server" Text="Staff Address" width="82px"></asp:Label>
        <asp:TextBox ID="txtStaffAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffMoNumber" runat="server" Text="Staff Mobile Number" width="82px"></asp:Label>
        <asp:TextBox ID="txtStaffMoNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role" width="82px"></asp:Label>
        <asp:TextBox ID="txtStaffRole" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffDateAdded" runat="server" Text="Staff Date Added" width="82px"></asp:Label>
        <asp:TextBox ID="txtStaffDateAdded" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="Ok" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="400px" Width="798px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Enter a Staff Role"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>

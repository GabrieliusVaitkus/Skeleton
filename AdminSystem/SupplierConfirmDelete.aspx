﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 81px; width: 365px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </p>
    </form>
</body>
</html>

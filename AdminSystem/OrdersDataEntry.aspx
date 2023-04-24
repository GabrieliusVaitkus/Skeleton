<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; left: 127px; top: 70px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="tblOrderNo" runat="server" style="z-index: 1; left: 10px; top: 72px; position: absolute; height: 22px; width: 100px" Text="Order Number"></asp:Label>
    </form>
</body>
</html>

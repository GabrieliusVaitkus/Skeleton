<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtOrderNo" runat="server" Style="z-index: 1; left: 125px; top: 50px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtQuantity" runat="server" Style="z-index: 1; left: 125px; top: 75px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtOrderDate" runat="server" Style="z-index: 1; left: 125px; top: 100px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDeliveryAddress" runat="server" Style="z-index: 1; left: 125px; top: 125px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtTotalPrice" runat="server" Style="z-index: 1; left: 125px; top: 150px; position: absolute"></asp:TextBox>

        </div>
        <asp:Label ID="tblOrderNo" runat="server" Style="z-index: 1; left: 10px; top: 50px; position: absolute; height: 22px; width: 100px" Text="Order Number"></asp:Label>
        <asp:Label ID="tblQuantity" runat="server" Style="z-index: 1; left: 10px; top: 75px; position: absolute; height: 22px; width: 100px" Text="Quantity"></asp:Label>
        <asp:Label ID="tblOrderDate" runat="server" Style="z-index: 1; left: 10px; top: 100px; position: absolute; height: 22px; width: 100px" Text="Order Date"></asp:Label>
        <asp:Label ID="tblDeliveryAddress" runat="server" Style="z-index: 1; left: 10px; top: 125px; position: absolute; height: 22px; width: 115px" Text="Delivery Address"></asp:Label>
        
        <asp:Label ID="tblTotalPrice" runat="server" Style="z-index: 1; left: 10px; top: 150px; position: absolute; height: 22px; width: 100px" Text="Total Price"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
            <asp:CheckBox ID="chkDelivered" runat="server" Text="Delivered" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" Width="60px" />
        </p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
    </form>
</body>
</html>

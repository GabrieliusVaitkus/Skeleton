<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;</div>
        <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 10px; top: 22px; position: absolute; height: 422px; width: 473px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 450px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 61px; top: 451px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 649px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 107px; top: 452px; position: absolute" Text="Delete" />
        <asp:Label ID="lblEACT" runat="server" style="z-index: 1; left: 19px; position: absolute; width: 146px; right: 379px; top: 521px" Text="Enter a card type"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 185px; top: 522px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 17px; top: 567px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 101px; top: 568px; position: absolute" Text="Clear" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCardNo" runat="server" style="z-index: 1; left: 10px; top: 37px; position: absolute" Text="Card Number" width="137px"></asp:Label>
        <p>
            <asp:TextBox ID="txtCardNo" runat="server" style="z-index: 1; top: 40px; position: absolute; left: 158px; height: 20px; width: 168px; margin-bottom: 5px">1007</asp:TextBox>
            <asp:Label ID="lblCardType" runat="server" style="z-index: 1; left: 11px; top: 118px; position: absolute" Text="Card Type" width="137px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCardDescription" runat="server" style="z-index: 1; left: 10px; top: 80px; position: absolute" Text="Card Description"></asp:Label>
        </p>
        <asp:TextBox ID="txtCardDescription" runat="server" style="z-index: 1; left: 157px; top: 82px; position: absolute; height: 20px; width: 168px">Water</asp:TextBox>
        <asp:TextBox ID="txtCardType" runat="server"  style="z-index: 1; left: 156px; top: 120px; position: absolute; height: 20px" width="168px" OnTextChanged="txtCardType_TextChanged">Trainer</asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 337px; top: 40px; position: absolute" Text="Find" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDataAdded" runat="server" style="z-index: 1; left: 10px; top: 160px; position: absolute; margin-bottom: 0px" Text="Date Added" width="137px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" height="20px" style="z-index: 1; left: 155px; top: 155px; position: absolute" width="168px">03/08/2020</asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 12px; top: 194px; position: absolute" Text="Price" width="137px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 154px; top: 199px; position: absolute; height: 20px; width: 168px" OnTextChanged="txtPrice_TextChanged">9.100</asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 10px; top: 235px; position: absolute" Text="Available" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 58px; top: 309px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 273px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 308px; position: absolute" Text="OK" />
    </form>
</body>
</html>

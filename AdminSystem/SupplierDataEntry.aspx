<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierNo" runat="server" Text="Supplier No" Width="180px"></asp:Label>
            <asp:TextBox ID="txtSupplierNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <p>
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" Width="157px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplierContactNo" runat="server" Text="Supplier Contact No" Width="180px"></asp:Label>
        <asp:TextBox ID="txtSupplierContactNo" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierEmail" runat="server" Text="Supplier Email" Width="168px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtSupplierEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblSupplierAddress" runat="server" Text="Supplier Address" Width="162px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtSupplierAddress" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateRegistered" runat="server" Text="Date of Register" Width="165px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtDateRegistered" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>

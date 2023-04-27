<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 4px; top: 30px; position: absolute; height: 265px; width: 384px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 309px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 53px; top: 309px; position: absolute" Text="Edit" />
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 26px; top: 350px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 97px; top: 309px; position: absolute; height: 26px; width: 56px" Text="Delete" />
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
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEnterAFirstName" runat="server" style="z-index: 1; left: 10px; top: 414px; position: absolute" Text="Enter  a first name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEnterAFirstName" runat="server" style="z-index: 1; left: 134px; top: 414px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 0px; top: 451px; position: absolute" Text="Apply" />
&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 53px; top: 453px; position: absolute" Text="Clear" />
        </p>
    </form>
</body>
</html>

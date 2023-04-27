<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 15px; top: 69px; position: absolute" Text="Yes" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 55px; top: 70px; position: absolute; height: 25px; width: 36px" Text="No" />
    </form>
</body>
</html>

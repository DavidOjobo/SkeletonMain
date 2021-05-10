<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="225px" Width="240px"></asp:ListBox>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" />
    </form>
</body>
</html>

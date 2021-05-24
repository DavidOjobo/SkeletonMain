<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QualityList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 365px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstProductList" runat="server" Height="326px" Width="338px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>

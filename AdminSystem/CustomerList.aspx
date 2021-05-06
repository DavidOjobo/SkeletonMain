<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 570px;
            width: 975px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="330px" Width="610px"></asp:ListBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        &nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        &nbsp;<asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Enter a name"></asp:Label>
        &nbsp;<asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        &nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
    </form>
</body>
</html>

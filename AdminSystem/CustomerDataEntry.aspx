<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="lblProductNo" runat="server">
        <div>
        </div>
        ProductNo<asp:TextBox ID="txtProductNo" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblSurname" runat="server" Text="Surname"></asp:Label>
        <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrder" runat="server" Text="OrderNo"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPhoneNo" runat="server" Text="PhoneNo"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID" width="160px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" width="160px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="160px"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" width="160px"></asp:TextBox>
        </p>
        <asp:Label ID="lblDate" runat="server" Text="Date" width="160px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" width="160px"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email" width="160px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" width="160px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address" width="160px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" width="160px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPostCode" runat="server" Text="PostCode" width="160px"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPhoneNo" runat="server" Text="Phone Number" width="160px"></asp:Label>
        <asp:TextBox ID="txtPhoneNo" runat="server" width="160px"></asp:TextBox>
        <p>
        <asp:Label ID="lblProductNo1" runat="server" Text="ProductNo" width="160px"></asp:Label>
        <asp:TextBox ID="txtProductNo" runat="server" OnTextChanged="txtProductNo_TextChanged" width="160px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" OnCheckedChanged="chkActive_CheckedChanged" Text="Active" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
        <asp:Label ID="lblOrder" runat="server" Text="OrderNo" width="160px"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server" width="160px"></asp:TextBox>
        </p>
    </form>
</body>
</html>

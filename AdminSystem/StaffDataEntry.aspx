<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    </body>
<form id="form1" runat="server">
    <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
    <br />
    <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblProductNumber" runat="server" Text="Product Number"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblOrderNumber" runat="server" Text="Order Number"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="ShippedStatus" runat="server" Text="Shipped Status"></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblError" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
</form>
</html>

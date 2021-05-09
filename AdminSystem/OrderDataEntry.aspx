<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductNo" runat="server" Text="Product Number" width="121px"></asp:Label>
        <asp:TextBox ID="txtProductNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        <br />
        <asp:Label ID="lblOrderNo" runat="server" Text="OrderNo" width="121px"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="121px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblDate" runat="server" Text="Date" width="121px"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox><br />
        <asp:CheckBox ID="txtDispatched" runat="server" Text="Dispatched" TextAlign="Left" width="121px" />
        <br />
            <asp:Label ID="lblError" runat="server"></asp:Label><br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" width="60px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>

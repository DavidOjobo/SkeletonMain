<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblProductNo" runat="server" Text=" Product Number" height="19px" width="121px"></asp:Label>
        <asp:TextBox ID="txtProductNo" runat="server"></asp:TextBox>
        <br />
        <div>
        <asp:Label ID="ProductDescription" runat="server" Text="Product Description"></asp:Label>
            <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
            <asp:Label ID="lblQuantityInStock" runat="server" Text="Quantity In Stock" height="19px" width="121px"></asp:Label>
        <asp:TextBox ID="txtProductInStock" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblQuantityOrdered" runat="server" height="19px" Text="Quantity Ordered" width="121px"></asp:Label>
            <asp:TextBox ID="txtQuantityOrdered" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" height="19px" Text="Price" width="121px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDate" runat="server" height="19px" Text="Date" width="121px"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Button" />
    </form>
</body>
</html>

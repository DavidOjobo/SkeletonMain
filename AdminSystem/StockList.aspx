﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="448px" Width="704px"></asp:ListBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
    </form>
</body>
</html>

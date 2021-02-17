<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QualityDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 279px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductNo" runat="server" Text="Product Number: "></asp:Label>
            <asp:TextBox ID="txtProductNo" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID: " width="109px"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblBatchNo" runat="server" Text="Batch Number: " width="109px"></asp:Label>
            <asp:TextBox ID="txtBatchNo" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblGrade" runat="server" Text="Grade: " width="109px"></asp:Label>
            <asp:DropDownList ID="ddlGrade" runat="server">
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
            </asp:DropDownList><br />
            <asp:Label ID="lblDate" runat="server" Text="Date Added: " width="109px"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox><br /><br />
            <asp:CheckBox ID="chkDefective" runat="server" Text="Defective" TextAlign="Left" /><br /><br />
            <asp:Label ID="lblError" runat="server"></asp:Label><br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" Width="60px" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>

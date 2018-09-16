<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Chanel 9 RSS</h1><br />
            <p>Click to link to read the article.</p></div>

        <asp:Table ID="FeedTable" runat="server" BorderColor="#333333" BorderStyle="Solid" BorderWidth="1px" CellPadding="5" Font-Names="Arial" GridLines="Both">

        </asp:Table>

    </form>
</body>
</html>

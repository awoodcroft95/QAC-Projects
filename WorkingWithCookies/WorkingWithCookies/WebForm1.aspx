﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WorkingWithCookies.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Process" />
    </form>
</body>
</html>

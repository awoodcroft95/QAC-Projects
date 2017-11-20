<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimesTable.aspx.cs" Inherits="TimeTables.TimesTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% int table = Int32.Parse(Request.QueryString["T"]);

                Response.Write("<h1> Times Table of " + table + "</h1>");
                for (int i = 1; i <= 10; i++)
                {
                    Response.Write($"{table} x {i} = {i * table} <br>");
                }
            %>
            <a href="home.aspx">home</a>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Third.aspx.cs" Inherits="TimesTablesHTTP.Third" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% int table = Int32.Parse(Request.QueryString["T"]);
                int range = Int32.Parse(Request.QueryString["R"]);

                Response.Write($"<h1> Times Table of {table}</h1><br><h2>Range of {range}</h2>");
                for (int i = 1; i <= range; i++)
                {
                    Response.Write($"{table} x {i} = {i * table} <br>");
                }
            %>
            <a href="First.aspx">Home</a>
        </div>
    </form>
</body>
</html>

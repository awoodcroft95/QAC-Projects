<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello My Friends
            <%
                for (int i = 0; i <= 10; i++)
                {
                    Response.Write("<br> Dynamic Text " + i);
                }
            %>
            <br />
            <a href="QA.aspx">QA</a>
            <h2>Times Tables</h2>
            <a href="TimesTable.aspx?T=2&R=10">2</a>
            <a href="TimesTable.aspx?T=3&R=20">3</a>
        </div>
    </form>
</body>
</html>

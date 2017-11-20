<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="TimesTablesHTTP.Second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Select Range of Times Table</h1>
            <% 
                string T = Request.QueryString["T"];
                for(int i = 10; i <= 100; i += 10)
                {
                    Response.Write($"<a href='Third.aspx?T={T}&R={i}'>{i}</a><br>");
                }
                %>
        </div>
    </form>
</body>
</html>

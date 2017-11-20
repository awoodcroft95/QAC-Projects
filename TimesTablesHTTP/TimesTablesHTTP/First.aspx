<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="TimesTablesHTTP.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Select Times Table</h1>
            <% 
                for (int i=1; i<=1000; i++)
                {
                    Response.Write($"<a href='Second.aspx?T={i}'>{i}</a><br>");
                }
                %>
        </div>
    </form>
</body>
</html>

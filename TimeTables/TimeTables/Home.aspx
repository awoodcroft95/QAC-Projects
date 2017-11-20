<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TimeTables.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%  
                for (int i = 1; i <= 20000; i++)
                {
                    Response.Write($"<a href='TimesTable.aspx?t={i}'>{i}</a><br>");
                }
                %>
        </div>
    </form>
</body>
</html>

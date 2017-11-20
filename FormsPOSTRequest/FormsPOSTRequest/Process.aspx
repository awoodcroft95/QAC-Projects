<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Process.aspx.cs" Inherits="FormsPOSTRequest.Process" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                int a = Int32.Parse(Request.Form["no1"]);
                int b = Int32.Parse(Request.Form["no2"]);
                Response.Write($"The result is {a + b}");
            %>
        </div>
    </form>
</body>
</html>

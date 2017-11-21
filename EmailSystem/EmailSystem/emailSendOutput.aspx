<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="emailSendOutput.aspx.cs" Inherits="EmailSystem.emailSendOutput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                if (Request.QueryString["sent"].ToString() == "True")
                {
                    Response.Write("Email Sent <a href='inbox.aspx'>Back To Inbox</a>");
                }
                else
                {
                    Response.Write("Email Failed To Send <a href='composeEmail.aspx'>Back To Compose Email</a> <br> <a href='inbox.aspx'>Back To Inbox</a>");
                }
                %>
        </div>
    </form>
</body>
</html>

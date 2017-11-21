<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="handleEmailSelect.aspx.cs" Inherits="EmailSystem.handleEmailSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                if (Session["user"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Session["emailID"] = Request.QueryString["ID"];
                    Response.Redirect("EmailPage.aspx");
                }
                %>
        </div>
    </form>
</body>
</html>

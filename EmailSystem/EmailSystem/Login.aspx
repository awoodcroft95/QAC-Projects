<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmailSystem.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="inbox.aspx" method="post">
        <div>
            Username<input type="text" name="user" />
            Password<input type="password" name="pass" />
            <input type="submit" />
        </div>
    </form>
</body>
</html>

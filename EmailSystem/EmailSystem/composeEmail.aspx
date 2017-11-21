<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="composeEmail.aspx.cs" Inherits="EmailSystem.composeEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="handleSendEmail.aspx">
        <div>
            To: <input type="text" name="to"/><br />
            Subject: <input type="text" name="subject"/><br />
            Body: <input type="text" name="body"/>
            <input type="submit" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FormsPOSTRequest.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="Process.aspx" method="post">
        <div>
            First No: <input type="text" name="no1"/><br />
            Second No: <input type="text" name="no2" /> <br />
            <input type="submit" value="click" />
        </div>
    </form>
</body>
</html>

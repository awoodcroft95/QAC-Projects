<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFormToolBox.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Input:
            <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="180px"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        Output:
        <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="180px"></asp:TextBox>
    </form>
</body>
</html>

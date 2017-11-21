<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WorkingWithCookies.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Num1:
        <asp:TextBox ID="Num1" runat="server"></asp:TextBox>
        <p>
            Num2:
            <asp:TextBox ID="Num2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        <p>
            <asp:TextBox ID="Output" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
    </form>
</body>
</html>

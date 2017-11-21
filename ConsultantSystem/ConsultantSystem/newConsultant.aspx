<%@ Page Title="" Language="C#" MasterPageFile="~/SiteTemplate.Master" AutoEventWireup="true" CodeBehind="newConsultant.aspx.cs" Inherits="ConsultantSystem.newConsultant" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    Name:<br />
    <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
    <br />
    Address:<br />
    <asp:TextBox ID="addressBox" runat="server"></asp:TextBox>
    <br />
    Email:<br />
    <asp:TextBox ID="emailBox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="submit" runat="server" Text="Submit" />

</asp:Content>

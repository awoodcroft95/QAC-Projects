<%@ Page Title="" Language="C#" MasterPageFile="~/SiteTemplate.Master" AutoEventWireup="true" CodeBehind="editPage.aspx.cs" Inherits="ConsultantSystem.editPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%


    %>Name:<br />
    <asp:TextBox ID="nameInput" runat="server"></asp:TextBox>
    <br />
    Address:<br />
    <asp:TextBox ID="addressInput" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
</asp:Content>

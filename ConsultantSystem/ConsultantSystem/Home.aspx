<%@ Page Title="" Language="C#" MasterPageFile="~/SiteTemplate.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ConsultantSystem.Home" %>
<%@ Import Namespace="ConsultantSystem" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="1">
        <tr>
            <th>Serial No</th>
            <th>Name</th>
            <th>Address</th>
            <th>Edit/Delete</th>
        </tr>
        <%
            Home.cmd.CommandText = "select * from PersonalInfo";
            Home.data = Home.cmd.ExecuteReader();
            int i = 1;
            while (Home.data.Read())
            {
                Response.Write($"<tr><td>{i}</td><td>{Home.data["Name"]}</td><td>{Home.data["Address"]}");
                Response.Write($"</td><td><a href='editPage.aspx?id={Home.data["UID"]}'>edit</a>, <a href='deletePage.aspx?id={Home.data["UID"]}'>delete</a></td></tr>");
                i++;
            }
            data.Close();
            %>
    </table>
</asp:Content>


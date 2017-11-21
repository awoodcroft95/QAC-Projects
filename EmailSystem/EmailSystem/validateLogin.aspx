<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validateLogin.aspx.cs" Inherits="EmailSystem.validateLogin" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\AWCSharpProjects\\EmailSystem\\EmailSystem\\App_Data\\EmailDatabase.mdf;Integrated Security=True";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = $"select * from users where username = '{Request.Form["user"].ToString()}' and password = '{Request.Form["pass"].ToString()}'";
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    Session["user"] = data["username"].ToString();
                    Response.Redirect("inbox.aspx");
                }
                else
                {
                    Response.Redirect("invalidLogin.aspx");
                }
            %>
        </div>
    </form>
</body>
</html>

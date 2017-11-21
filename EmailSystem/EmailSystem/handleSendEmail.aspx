<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="handleSendEmail.aspx.cs" Inherits="EmailSystem.handleSendEmail" %>

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
                cmd.CommandText = $"insert into emails values('{Session["user"].ToString()}', '{Request.Form["to"].ToString()}', '{Request.Form["subject"].ToString()}', '{Request.Form["body"].ToString()}', getdate(), 'N', null)";
                int a = cmd.ExecuteNonQuery();
                if (a == 0)
                {
                    Response.Redirect("emailSentOutput.aspx?sent=True");
                }
                else
                {
                    Response.Redirect("emailSentOutput.aspx?sent=False");
                }
            %>
        </div>
    </form>
</body>
</html>

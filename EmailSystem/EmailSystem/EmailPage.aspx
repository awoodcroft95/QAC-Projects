<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmailPage.aspx.cs" Inherits="EmailSystem.EmailPage" %>
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
                if (Session["user"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\AWCSharpProjects\\EmailSystem\\EmailSystem\\App_Data\\EmailDatabase.mdf;Integrated Security=True";
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    int emailId = Int32.Parse(Session["emailId"].ToString());
                    cmd.CommandText = $"select * from emails where EmailID = '{emailId}'";
                    SqlDataReader emailData = cmd.ExecuteReader();
                    while (emailData.Read())
                    {
                        Response.Write(emailData["body"].ToString());
                    }
                    emailData.Close();
                    cmd.CommandText = $"update emails set status = 'O' where EmailID = '{emailId}'";
                    cmd.ExecuteNonQuery();
                }
            %>
        </div>
    </form>
</body>
</html>

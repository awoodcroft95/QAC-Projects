<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inbox.aspx.cs" Inherits="EmailSystem.inbox" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to Your Inbox!</h1>
            <%  
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\AWCSharpProjects\\EmailSystem\\EmailSystem\\App_Data\\EmailDatabase.mdf;Integrated Security=True";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = $"select * from users where username = '{Request.Form["user"].ToString()}' and password = '{Request.Form["pass"].ToString()}'";
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read())
                {
                    Response.Write($"<h1>{data["username"].ToString()}'s Emails</h1>");
                    string username = data["username"].ToString();
                    data.Close();
                    cmd.CommandText = $"select * from emails where Recipient = '{username}'";
                    SqlDataReader emails = cmd.ExecuteReader();
                    while (emails.Read())
                    {
                        if (emails["status"].ToString().Equals('N'))
                        {
                            Response.Write("<b>");
                            Response.Write($"<a href='EmailPage.aspx'> {emails["from"].ToString()} | {emails["subject"].ToString()} | {emails["date"].ToString()}</a> <br>");
                            Response.Write("</b>");
                        }
                        else
                        {
                            Response.Write($"<a href='EmailPage.aspx'> {emails["from"].ToString()} | {emails["subject"].ToString()} | {emails["date"].ToString()}</a> <br>");
                        }
                    }
                    Response.Write("End Of Inbox");
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inbox.aspx.cs" Inherits="EmailSystem.inbox" %>

<%@ Import Namespace="System.Data.SqlClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        table, th, td {
            border: 2px solid black;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to Your Inbox!</h1>
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
                    Response.Write($"<h1>{Session["user"].ToString()}'s Emails</h1>");
                    string username = Session["user"].ToString();
                    cmd.CommandText = $"select * from emails where Recipient = '{username}' order by Date";
                    SqlDataReader emails = cmd.ExecuteReader();
                    Response.Write("<table><tr><th>Status</th><th>From</th><th>Subject</th><th>Date</th></tr>");
                    while (emails.Read())
                    {
                        if (emails["status"].ToString().Equals("N"))
                        {
                            Response.Write($"<tr style='font-weight:bold'><td>U</td><td>{emails["from"].ToString()}</td> <td><a href='handleEmailSelect.aspx?ID={emails["emailID"].ToString()}'>{emails["subject"].ToString()}</a></td> <td>{emails["date"].ToString()}</td>");
                        }
                        else
                        {
                            Response.Write($"<tr><td>R</td><td>{emails["from"].ToString()}</td> <td><a href='handleEmailSelect.aspx?ID={emails["emailID"].ToString()}'>{emails["subject"].ToString()}</a></td> <td>{emails["date"].ToString()}</td>");
                        }
                        Response.Write("</tr>");
                    }
                    Response.Write("</table>");
                    Response.Write("<a href='composeEmail.aspx'>Write New Email</a>");
                }
            %>
        </div>
        
    </form>
</body>
</html>

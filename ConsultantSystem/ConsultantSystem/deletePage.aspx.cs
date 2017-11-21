using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultantSystem
{
    public partial class deletePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Home.cmd.CommandText = $"delete from PersonalInfo where UID = '{Request.QueryString["ID"]}'";
            int a = Home.cmd.ExecuteNonQuery();
            if (a == 0)
            {
                Response.Write("Failed to delete from database. <br> <a href='Home.aspx'>Home</a>");
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}
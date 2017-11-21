using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultantSystem
{
    public partial class editPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            Home.cmd.CommandText = $"update PersonalInfo set Name = '{nameInput.Text}', Address = '{addressInput.Text}' where UID = '{Request.QueryString["ID"]}'";
            Response.Redirect("Home.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithCookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static HttpCookie aCookie = new HttpCookie("nameStore");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (aCookie.Value != null)
            {
                Response.Redirect("WebForm2.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            aCookie.Value = TextBox1.Text;
            Response.Cookies.Add(aCookie);
        }
    }
}
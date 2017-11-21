using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithCookies
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome " + WebForm1.aCookie.Value);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(Num1.Text);
            int num2 = Int32.Parse(Num2.Text);

            Output.Text = "" + (num1 + num2);
        }
    }
}
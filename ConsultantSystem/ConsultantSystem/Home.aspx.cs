using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ConsultantSystem
{
    public partial class Home : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader data;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\AWCSharpProjects\\ConsultantSystem\\ConsultantSystem\\App_Data\\ConsultantDB.mdf;Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand();
        }


    }
}
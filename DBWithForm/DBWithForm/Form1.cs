using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBWithForm
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        bool hasBeenClicked = false;
        SqlDataReader data;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Admin\\Documents\\AWCSharpProjects\\DBWithForm\\DBWithForm\\Database1.mdf';Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from school";
            data = cmd.ExecuteReader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Close();
            cmd.CommandText = "select isnull(max(Regno), 0)+1 as newR from school";
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                string newRegno = r["newR"].ToString();
                r.Close();
                string query = $"insert into school values({newRegno}, '{t2.Text}',{t3.Text})";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show($"New record added to School, with values {newRegno}, {t2.Text}, {t3.Text}");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (data.Read())
            {
                t1.Text = data["Regno"].ToString();
                t2.Text = data["Name"].ToString();
                t3.Text = data["Marks"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (data.Read())
            {
                t1.Text = data["Regno"].ToString();
                t2.Text = data["Name"].ToString();
                t3.Text = data["Marks"].ToString();
            }
        }
    }
}

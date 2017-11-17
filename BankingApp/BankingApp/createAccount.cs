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

namespace BankingApp
{
    public partial class CreateNewAccount : Form
    {
        SqlCommand cmd;
        string accountType = "";
        string gender = "";
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = MainMenu.DBConnection;
            cmd = con.CreateCommand();
            accountType = currentRadButton.Checked ? "C" : "S";
            gender = maleRadButton.Checked ? "M" : "F";
            cmd.CommandText = $"select concat('{accountType}','{gender}', right(replicate('0', 3) + cast(isnull(max(substring(accNo, 3, 3))+1,'001') as varchar(15)), 3)) as NewAccNo from Accounts where substring(accNo,1,1) = '{accountType}'";
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                string newAccNumber = r["NewAccNo"].ToString();
                r.Close();
                cmd.CommandText = $"insert into Accounts values('{newAccNumber}', '{textBox1.Text}', '{textBox2.Text}', 'A')";
                cmd.ExecuteNonQuery();
            }
        }
    }
}

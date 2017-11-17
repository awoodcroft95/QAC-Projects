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
    public partial class Deposit : Form
    {
        SqlCommand cmd;

        public Deposit()
        {
            InitializeComponent();
        }

        private void searchConfirm(Object sender, EventArgs e)
        {

        }

        private void searchConfirm(object sender, KeyPressEventArgs e)
        {

        }

        private void handleSearch()
        {
            SqlConnection con = MainMenu.DBConnection;
            cmd = con.CreateCommand();
            cmd.CommandText = $"select * from accounts where accNo ={accNoBox.Text}";
            SqlDataReader data = cmd.ExecuteReader();
            if (!data.Read()){
                MessageBox.Show("Invalid account number");
            }
            else
            {
                if (data["Status"].ToString().Equals("D")){
                    MessageBox.Show("Account is deactivated");
                }
                else{

                }
            }
        }
    }
}

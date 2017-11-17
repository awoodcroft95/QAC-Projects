using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class MainMenu : Form
    {
        private static SqlConnection con;
        public static SqlConnection DBConnection {
            get
            {
                return con;
            }
        }

        private CreateNewAccount newAccountWindow;
        private DepositAndWithdraw newDepositAndWithdrawWindow;
        public MainMenu()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Documents\\AWCSharpProjects\\BankingApp\\BankingApp\\BankDatabase.mdf;Integrated Security=True";
            con.Open();
            newAccountWindow = new CreateNewAccount();
            newDepositAndWithdrawWindow = new DepositAndWithdraw();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAccountWindow.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDepositAndWithdrawWindow.Show();
            newDepositAndWithdrawWindow.setWindowType("deposit");
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDepositAndWithdrawWindow.Show();
            newDepositAndWithdrawWindow.setWindowType("withdraw");
        }
    }
}

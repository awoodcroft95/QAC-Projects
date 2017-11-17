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
    public partial class DepositAndWithdraw : Form
    {
        SqlCommand cmd;
        string windowType;
        string accountNo = "";

        public DepositAndWithdraw()
        {
            InitializeComponent();
            inputBox.Maximum = Decimal.MaxValue;
        }

        private void searchConfirm(Object sender, EventArgs e)
        {
            handleSearch();
        }

        private void searchConfirm(object sender, KeyPressEventArgs e)
        {   if(e.KeyChar == (char)13)
            {
                handleSearch();
            }
        }
        
        public void setWindowType(string type)
        {
            this.Text = type;
            windowType = type;
            if (type.Equals("withdraw"))
            {
                transactionTypeLabel.Text = "Withdraw Amount:";
            }
            else if (type.Equals("deposit"))
            {
                transactionTypeLabel.Text = "Deposit Amount:";
            }
        }

        private void handleSearch()
        {
            SqlConnection con = MainMenu.DBConnection;
            cmd = con.CreateCommand();
            cmd.CommandText = $"select * from Accounts where accNo ='{accNoBox.Text}'";
            SqlDataReader data = cmd.ExecuteReader();
            if (!data.Read())
            {
                MessageBox.Show("Invalid account number");
            }
            else
            {
                if (data["Status"].ToString().Equals("D"))
                {
                    MessageBox.Show("Account is deactivated");
                }
                else
                {
                    accountNo = accNoBox.Text;
                    nameBox.Text = data["Name"].ToString();
                    addressBox.Text = data["Address"].ToString();
                    accountTypeBox.Text = accNoBox.Text.Substring(0, 1).Equals("C") ? "Current" : "Savings";
                    genderBox.Text = accNoBox.Text.Substring(1, 1).Equals("M") ? "Male" : "Female";
                    cmd.CommandText = $"select sum(deposits.amount)-sum(Withdraws.amount) as balance from deposits,withdraws where deposits.accno=withdraws.accno and deposits.accno='{accountNo}'";
                    data.Close();
                    SqlDataReader balanceData = cmd.ExecuteReader();
                    if (balanceData.Read())
                    {
                        balanceBox.Text = balanceData["balance"].ToString();
                        balanceData.Close();
                    }
                    else
                    {
                        MessageBox.Show("The account you have selected does not have a valid balance.");
                    }
                }
            }
        }

        private void handleDeposit()
        {
            float depositAmount = (float) inputBox.Value;
            if (depositAmount > 0)
            {
                cmd.CommandText = $"insert into deposits values('{accountNo}', '{depositAmount}', getdate())";
                cmd.ExecuteNonQuery();
                MessageBox.Show($"£{depositAmount} deposited into account:{accountNo}");
            }
        }

        private void handleWithdraw()
        {
            float withdrawAmount = (float)inputBox.Value;
            if (withdrawAmount > 0 && Int32.Parse(balanceBox.Text) - withdrawAmount > 0)
            {
                cmd.CommandText = $"insert into withdraws values('{accountNo}', '{withdrawAmount}', getdate())";
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"£{withdrawAmount} deposited into account:{accountNo}");
                }
                catch
                {
                    MessageBox.Show("Failed to withdraw ");
                }
                
            }
            else
            {
                MessageBox.Show("Not enough money in account to complete withdraw.");
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (windowType.Equals("deposit"))
            {
                handleDeposit();
            }
            else if (windowType.Equals("withdraw"))
            {
                handleWithdraw();
            }
        }
    }
}

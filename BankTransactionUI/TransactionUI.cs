using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTransactionUI
{
    public partial class TransactionUI : Form
    {
        Account account = new Account();
        public TransactionUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            account.CreateAccount(accountNoTextBox.Text,nameTextBox.Text);
            accountNoTextBox.Clear();
            nameTextBox.Clear();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            account.Deposit(Convert.ToDouble(accountTextBox.Text));
            MessageBox.Show(accountTextBox.Text + " Deposited ");
        }

        private void widthdrawButton_Click(object sender, EventArgs e)
        {
            if (account.Balance > 0)
            {
                MessageBox.Show(accountTextBox.Text + " Widthdrawn");
                account.Widthdraw(Convert.ToDouble(accountTextBox.Text));
                return;
            }
            MessageBox.Show("Sorry You have Insufficience Balance");

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.CustomerName+" Your Account Number: "+account.AccountNumber+" and Balance: "+account.Balance);
        }
    }
}

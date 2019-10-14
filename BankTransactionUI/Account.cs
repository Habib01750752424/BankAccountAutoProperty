using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransactionUI
{
    public class Account
    {
        public string AccountNumber { set; get; }
        public string CustomerName { set; get; }
        public double Balance { set; get; }

        public void CreateAccount(string aNo,string cName)
        {
            AccountNumber = aNo;
            CustomerName = cName;
        }

        public double Deposit(double balance)
        {
            Balance = Balance + balance;
            return Balance;
        }

        public double Widthdraw(double balance)
        {
            Balance = Balance - balance;
            return Balance;
        }
    }
}

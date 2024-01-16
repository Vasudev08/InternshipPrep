using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Classes
{
    public class BankAccount
    {

        public BankAccount()
        {
            Balance = 100;
        }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }
        // Properties --> adds security of viewing it 
        private double balance; // variable for holding account balance
        public double Balance
        {
            get 
            { 
                if (balance < 1000000)
                    return balance;
                return 100000000;
            }
            protected set
            { 
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }



        public double AddtoBalance(double balanceToBeAdded)
        {
            Balance += balanceToBeAdded;
            return Balance;
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 10;
        }
    }
}

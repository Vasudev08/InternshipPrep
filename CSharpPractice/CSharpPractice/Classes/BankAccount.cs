using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPractice.Interfaces;


namespace CSharpPractice.Classes
{
    public class BankAccount : IInformation
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


        //C# use of virtual -> makes it type safe i.e. function overriding using virtual and override for function overriding
        // function overloading -> difference parameters 
        // fucntion override -> virutal and override keyword

        // a class can only herit from one another class
        public virtual double AddtoBalance(double balanceToBeAdded)
        {
            Balance += balanceToBeAdded;
            return Balance;
        }

        public string GetInformation()
        {
            return $"Your current balance is: {Balance:c}";
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 10;
        }

        public override double AddtoBalance(double balanceToBeAdded)
        {
            if (balanceToBeAdded > 1000)
                balanceToBeAdded = 1000;
            if (balanceToBeAdded < -1000)
                balanceToBeAdded = -1000;
            return base.AddtoBalance(balanceToBeAdded);
        }
    }
}

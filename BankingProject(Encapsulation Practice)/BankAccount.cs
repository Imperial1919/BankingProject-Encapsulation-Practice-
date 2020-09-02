using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject_Encapsulation_Practice_
{
    class BankAccount
    {
        private double balance = 0;


        public void Deposit(double depositAmount)
        {
           balance += depositAmount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double withdrawAmount)
        {
            balance -= withdrawAmount;
        }
    }
}

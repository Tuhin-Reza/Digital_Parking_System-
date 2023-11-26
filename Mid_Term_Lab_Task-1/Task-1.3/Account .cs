using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._3
{
    class Account
    {
        String accName;
        String accid;
        int balance;
        public void setaccname(string newaccname)
        {
            accName = newaccname;
        }
        public void setaccid(string newaccid)
        {
            accid = newaccid;
        }
        public void setbalance(int newbalance)
        {
            balance = newbalance;
        }
        public String getaccname()
        {
            return accName;
        }
        public String getaccid()
        {
            return accid;
        }
        public int getbalancde()
        {
            return balance;
        }
        public int Deposit(int amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Amount is very low can not Deposit");
            }
            return balance;
        }
        public int Withdraw(int amount)
        {
            if (amount > 0)
            {
                balance = balance -amount;
            }
            else
            {
                Console.WriteLine("Amount is very low can not Withdraw");
            }
            return balance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("\n\n---------Account  Information---------");
            Console.WriteLine("\n Account Name        : " + accName);
            Console.WriteLine(" Account ID           : " + accid);
            Console.WriteLine(" Balance              : " + balance);
        }
    }
}

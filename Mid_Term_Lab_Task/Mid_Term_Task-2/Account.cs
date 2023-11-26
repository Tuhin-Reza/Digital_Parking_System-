using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Term_Task_2
{
    class Account
    {
        String accName;
        String acid;
        int balance;
        public Account()
        {
            Console.WriteLine("Default cnstructor Called");
        }
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public string Name
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Id
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Can Not Deposit");
            }
        }
        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public void Transfer(int amount, Account reciever)
        {

            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance:	" + this.balance);
                Console.WriteLine("Transfer Amount:	" + amount);
                this.balance = this.balance - amount;
                reciever.balance = reciever.balance + amount;
                Console.WriteLine("Current Balance:	" + this.balance);
            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name     : " + accName);
            Console.WriteLine("Account Number   : " + acid);
            Console.WriteLine("Account Balance  : " + balance);
        }
    }
}

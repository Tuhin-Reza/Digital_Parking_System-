using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_2
{
    class Savings :Account
    {
        double balance;
        string accType;
        string id;
        double  saving_balance;
        public Savings() { }
      
        public Savings(string accType,string id,double balance)
        {
            this.accType = accType;
            this.id = id;
            this.balance = balance;
        }
        public string Type
        {
            get { return accType; }
            set { accType = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public bool deposit(double amount)
        {

            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("After Deposit your Account Balance : " + balance + "\n");
                return true;
            }
            else
            {
                Console.WriteLine("Amount is very low can not Deposit");
                return false;
            }
        }

        public bool withdraw(double  amount)
        {
            saving_balance = 0.8* balance;
            balance =saving_balance -balance;
            if (balance >=amount)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawed Balance                 : " + amount);
                Console.WriteLine("Your Saving balance                : " + saving_balance + "\n");
                return true;
            }
            else
            {
                Console.WriteLine("---Cannot Withdrw Please Check Your Balance---");
                return false;
            }
        }
        public void change_acc_type(string type)
        {
            this.accType = type;

        }
    }
}

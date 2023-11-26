using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_2
{
    class Current : Account
    {
        double balance;
        string accType;
        string id;
        public Current() { }
        public Current(string accType, string id, double balance)
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
                Console.WriteLine("After Deposit your Account Balance :" + balance +"\n");
                return true;
            }
            else
            {
                Console.WriteLine("Amount is very low can not Deposit");
                return false;
            }
        }

        public  bool withdraw(double amount )
        {

            if (balance>amount && "Cur"==accType.Substring(0,3))
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawed Balance                 : " + amount);
                Console.WriteLine("After withdrw Your Account balance : " + balance+"\n");
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

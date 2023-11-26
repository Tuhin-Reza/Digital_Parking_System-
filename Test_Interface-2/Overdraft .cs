using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_2
{
    class Overdraft : Account
    {
        double balance;
        string accType;
        string id;
        double OVERDRAFT_LIMIT = 5000;
        bool od;
        public Overdraft() { }
        public Overdraft(string accType, string id, double balance)
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

        public bool overdraft(double amount)
        {
            if (balance <= 0 && OVERDRAFT_LIMIT>amount && OVERDRAFT_LIMIT != 0)
            {              
                balance = OVERDRAFT_LIMIT;
                OVERDRAFT_LIMIT = OVERDRAFT_LIMIT - balance;
                Console.WriteLine("---Overdraft Suessfull---");
                return od= true;
            }
            else
            {
                Console.WriteLine("Not Eligiable For Overdraft");
                return od=false;
            }
        }
        /*public bool deposit(double amount)
        {
            if (amount > 0)
            {
                if (od = true  && OVERDRAFT_LIMIT !=5000)
                {
                    OVERDRAFT_LIMIT = amount;
                    Console.WriteLine("After Deposit your OVERDRAFTS Balance :" + OVERDRAFT_LIMIT + "\n");
                }
                balance =amount;

                
                Console.WriteLine("After Deposit your Account Balance :" + balance + "\n");
                return true;
            }
            else
            {
                Console.WriteLine("Amount is very low can not Deposit");
                return false;
            }
        }*/
        public bool withdraw(double amount)
        {

            if (balance==0)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawed Balance                 : " + amount);
                Console.WriteLine("After withdrw Your Account balance : " + balance + "\n");
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

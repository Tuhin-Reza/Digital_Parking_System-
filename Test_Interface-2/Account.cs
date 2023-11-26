using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Interface_2
{
    class Account : BasicBankingInterface
    {
        double balance;
        string accType;
        string id; 
        double saving_balance;
        double OVERDRAFT_LIMIT = 5000;
        public Account() { }

        public Account(string accType, string id, double balance)
        {
            this.accType = accType;
            this.id = id;
            this.balance = balance;
        }
        
        public bool deposit(double amount)
        {

            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("\nAfter Deposit your Account Balance :" + balance + "\n");
                return true;
                /* if (OVERDRAFT_LIMIT == 0 || OVERDRAFT_LIMIT !=5000)
                 {
                     OVERDRAFT_LIMIT = OVERDRAFT_LIMIT + amount;
                     if (amount > OVERDRAFT_LIMIT)
                     {
                         amount = amount - OVERDRAFT_LIMIT;
                         return true;
                     }
                     else
                     {
                         amount =OVERDRAFT_LIMIT-amount;
                         return true;

                     } 
                 }
                 else
                 {
                     balance = balance + amount;
                     Console.WriteLine("After Deposit your Account Balance :" + balance + "\n");
                     return true;
                 }*/
            }
            else
            {
                Console.WriteLine("Amount is very low can not Deposit");
                return false;
            }
        }

        public bool withdraw(double amount)
        {
            if (balance >= amount && "Cur" == accType.Substring(0, 3))
            {
                balance = balance - amount;
                Console.WriteLine("\n-----Current Account----- \n");
                Console.WriteLine("--->withdrawed Balance                 : " + amount);
                Console.WriteLine("--->After withdrw Your Account balance : " + balance + "\n");
                return true;
            }
            else if (balance >= amount && "Sav" == accType.Substring(0, 3))
            {
                saving_balance = 0.8 * balance;
                balance = balance - saving_balance;
                Console.WriteLine("\n--->Avaible Balance                  : " + balance+"\n");
                if (balance >= amount && accType == "Saving")
                {
                    balance = balance - amount;
                    Console.WriteLine("\n-----Saving  Account-----\n ");
                    Console.WriteLine("--->Withdrawed Balance                 : " + amount);
                    Console.WriteLine("--->After withdrw Your Account balance : " + balance + "\n");
                    Console.WriteLine("--->Your Saving balance                : " + saving_balance + "\n");
                    balance = saving_balance + balance;
                    return true;
                }
                else
                {
                    Console.WriteLine("---Cannot Withdrw Saving Balance---");
                    balance = saving_balance + balance;
                    return false;
                }
            }
            else if (balance == 0 && "Ove" == accType.Substring(0, 3))
            {
                if (balance <= 0 && OVERDRAFT_LIMIT != 0)
                {
                    balance = OVERDRAFT_LIMIT;
                    OVERDRAFT_LIMIT = OVERDRAFT_LIMIT - balance;
                    Console.WriteLine("\n---Overdraft Suessfull---\n");
                    Console.WriteLine("Now Your Account balance : " + balance + "\n");
                    return true;
                }
                else
                {
                    Console.WriteLine("---OverDraft Unsuessfull---");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Cannot Withdrw Please Check Your Balance---");
                return false;
            }
        }
        public void change_acc_type(string type)
        {
            Console.WriteLine("--->Change Account Type [" +  this.accType  + "] to ["  + type +  "]");
            this.accType = type;
        }
    }
}

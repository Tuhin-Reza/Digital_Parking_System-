using System;

namespace Test_Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Account cur= new Current();
            cur.Type = "Current";
            cur.deposit(100);
            cur.withdraw(10);
            cur.change_acc_type("Saving");
            cur.withdraw(10);

            Account sav = new Savings();
            sav.Type = "Saving";
            sav.deposit(100);
            sav.withdraw(20);
            sav.change_acc_type("Current");
            sav.withdraw(80);

            Account ove = new Overdraft();
            ove.Type = "Overdraft";
            ove.withdraw(500);
            ove.change_acc_type("Saving");
            ove.withdraw(3000);
            ove.change_acc_type("Current");
            ove.withdraw(5000);

           /* Account cur2 = new Current();
            cur2.Type = "Current";
            cur2.deposit(7000);*/

            Console.ReadLine();
        }
    }
}

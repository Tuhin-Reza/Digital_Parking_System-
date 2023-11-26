using System;

namespace Task_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account();
            ac1.setaccname("wwwww");
            ac1.setaccid("333333");
            ac1.setbalance(500);
            ac1.Deposit(1000);
            ac1.Withdraw(200);
            ac1.ShowInfo();

            Account ac2 = new Account();
            ac2.setaccname("xxxxx");
            ac2.setaccid("22222");
            ac2.setbalance(100);
            ac2.Deposit(10);
            ac2.Withdraw(0);
            ac2.ShowInfo();

            Console.ReadKey();
        }
    }
}

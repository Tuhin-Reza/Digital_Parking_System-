using System;

namespace Task_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new Account("wwwww", "333333", 500);
            ac1.Deposit(10);
            ac1.Withdraw(20);

            Account ac2 = new Account();
            ac2.Name=("yyyyy");
            ac2.Id=("55555");
            ac2.Balance=500;
            ac2.Deposit(1000);
            ac2.Withdraw(200);
            

            Account ac3 = new Account();
            ac3.setaccname("xxxxx");
            ac3.setaccid("22222");
            ac3.setbalance(100);
            ac3.Deposit(10);
            ac3.Withdraw(0);

            ac1.ShowInfo();
            ac2.ShowInfo();
            ac3.ShowInfo();

            Console.ReadKey();
        }
    }
}

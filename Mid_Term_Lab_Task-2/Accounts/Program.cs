using System;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("Tom", "1111", 1000);
            
            Account acc2= new Account("Jerry", "2222", 500);

            acc.ShowInfo();
            acc2.ShowInfo();

            acc.Transfer(100, acc2);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

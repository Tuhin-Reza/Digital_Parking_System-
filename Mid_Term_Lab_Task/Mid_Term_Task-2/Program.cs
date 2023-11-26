using System;

namespace Mid_Term_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("Radwan", "1212", 11000);
            a.ShowInfo();
            Account a2 = new Account("Radwan", "1212", 11000);

            a.Transfer(1000,a2);
            Console.WriteLine();
            Console.WriteLine("Hello World!");
        }
    }
}

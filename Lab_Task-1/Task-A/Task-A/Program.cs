using System;

namespace Task_A
{
    class Program
    {
        static void Main(string[] args)
        {

            Organization org1 = new Organization("Admin","aa","11",10);

            org1.show();

            Console.Write("\nEnter Employee Type           : ");
            string t = Console.ReadLine(); 
            Console.Write("Enter  Employee Name            : ");
            string n = Console.ReadLine();
            Console.Write("Enter  Employee  Id             : ");
            string i = Console.ReadLine();
            Console.Write("Enter  Employee Monthly Salary  : ");
            double s= Convert.ToDouble(Console.ReadLine());

            Organization org = new Organization(t,n,i,s);
            org.show();

            Console.ReadKey();
        }
    }
}

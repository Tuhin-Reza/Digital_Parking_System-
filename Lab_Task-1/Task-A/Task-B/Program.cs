using System;

namespace Task_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //SalesPerson sp1 = new SalesPerson("a",0,200);
            //Company cp1 = new Company();
            //cp1.AddNewPerson(sp);

            // cp1.AddGros_Sale(sp,5000);
            //cp1.ShowInfo();

            Console.Write("How many Sales Person you want to enter : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Sales Person Name       :");
                String name = Console.ReadLine();
                Console.Write("Enter Sales Person Week Sale :");
                double s = Convert.ToDouble(Console.ReadLine());
                SalesPerson sp = new SalesPerson(name);

                Company cp = new Company();
                cp.AddNewPerson(sp);

                cp.AddGros_Sale(sp, s);
                cp.ShowInfo();
            }

            Console.ReadKey();
        }
    }
}

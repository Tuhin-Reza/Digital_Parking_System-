using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Kiloigram Of Potato: ");
            int kilogram = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  Potato Price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("1 Kilogram Potato Tax 7%");
            double calculate = 0.007 * kilogram;
            double t_price = calculate + price;
            Console.Write("\nTotal Price Of Potato : " + t_price);
            Console.ReadKey();

        }
    }
}

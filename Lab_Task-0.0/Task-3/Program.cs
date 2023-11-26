using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Integer Number A : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Integer Number B : ");
            int B = Convert.ToInt32(Console.ReadLine());
            int temp = A;
            A = B;
            B = temp;
            Console.WriteLine("\nExchange Value of A : " + A);
            Console.WriteLine("Exchange Value of B : " + B);
            Console.ReadKey();

        }
    }
}

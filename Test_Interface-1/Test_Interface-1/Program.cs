using System;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ScientificCalculatorInterface sc = new ScientificCalculatorInterface();
            sc.sum(5,5);
            sc.sub(5, 5);
            sc.multiplication(5, 5);
            sc.division(5, 5);
            sc.toThePow(5, 5);
            sc.show();

            Console.ReadLine();
        }
    }
}

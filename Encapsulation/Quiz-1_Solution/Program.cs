using System;

namespace Quiz_1_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
           funcv(num);
           Console.WriteLine(num+",");
            funcr(ref num);
            Console.WriteLine(num+",");
            static void funcv(int num)
            {
                num = num + 10;
                Console.WriteLine(num+",");
            }
            static void funcr(ref int num)
            {
                num = num + 10;
                Console.WriteLine(num + ",");
            }
             
        }
    }
}

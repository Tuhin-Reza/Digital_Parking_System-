using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        public delegate void Operation(int x, int y);
        public static void Sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Sum : {0}",result);
        }
        public static void Sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Sub : {0}", result);
        }
        public static void Mul(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Mul : {0}", result);
        }
        public static void Div(int x, int y)
        {
            int result = x / y;
            Console.WriteLine("Div : {0}", result);
        }

        static void Main(string[] args)
        {
            //Operation o1 = new Operation(Program.Sum);
            //Operation o2 = new Operation(Program.Sub);
            //Operation o3 = new Operation(Program.Mul);
            //Operation o4 = new Operation(Program.Div);

            ////o1(20, 10);
            ////o2(20, 10);
            ////o3(20, 10);
            ////o4(20, 10);

            //o1.Invoke(20, 10);
            //o2.Invoke(20, 10);
            //o3.Invoke(20, 10);
            //o4.Invoke(20, 10);

            Operation o = new Operation(Program.Sum);
            o(20, 10);
            o = Sub;
            o(20, 10);
            o = Mul;
            o(20, 10);
            o = Div;
            o(20, 10);
        }
    }
}

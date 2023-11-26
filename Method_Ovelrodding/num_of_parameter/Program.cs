using System;

namespace num_of_parameter
{
    using System;
    class GFG
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public static void Main(String[] args)
        {
            GFG ob = new GFG();

            //int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two " + "integer value : " + ob.Add(1, 2));

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three " + "integer value : " + sum2);

            Console.ReadKey();
        }
    }
    /*class Program
    {
        public class TestOverloading
        {
            public void Add(string a1, string a2)
            {
                Console.WriteLine("Adding Two String :" + a1 + a2);
            }
            public void Add(int a1, int a2)
            {
                Console.WriteLine("Adding Two Integer :" + a1 + a2);
            }
        }
        static void Main(string[] args)
        {
            TestOverloading obj = new TestOverloading();
            obj.Add("Manish ", "Agrahari");
            //obj.Add(5, 10);
            Console.ReadLine();
        }
    }*/
}

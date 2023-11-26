using System;

namespace Changing_Order_Parameter
{
    class Program
    {
        public void Identity(String name, int id)
        {

            Console.WriteLine("Name : " + name + ", "
                              + "Id : " + id);
        } 
        public void Identity(int id, String name)
        {

            Console.WriteLine("Name : " + name + ", "
                              + "Id : " + id);
        }
        public static void Main(String[] args)
        {
            Program obj = new Program();

            obj.Identity("Akku", 1);
            obj.Identity("Abby", 2);
        }
    }
    /*class Program
    {
        public int Add(int a, int b)
        {

            int sum = a + b;
            return sum;
        }
        public double Add(double a, int b)
        {
            double sum = a + b;
            return sum;
        }
        public static void Main(String[] args)
        {
            Program ob = new Program();

            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two " + "integer value :" + sum1);

            int sum2 = ob.Add(1, 2);
            Console.WriteLine("sum of the three " + "integer value :" + sum2);
        }
    }*/
}

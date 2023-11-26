using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Demo
    {
        //public static void Array(int [] arr)
        //{
        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        //public static void Array(string[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        ////////// Generics
        public static void Array<T>(T [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //public static bool check(int a, int b)
        //{
        //        bool c = a.Equals(b);
        //        return c;
        //}

        //public static bool check<T>(T a, T b)
        //{
        //    bool c = a.Equals(b);
        //    //Console.WriteLine(typeof(T));
        //    return c;
        //}
        
        public static bool check(Object a, Object b)
        {
            bool c = a.Equals(b);
            //Console.WriteLine(typeof(T));
            return c;
        }

    }

    


    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0]=30;
            number[1]=40;
            number[2]=50;

            string [] name ={"Khan","Ali","Ahmed"};
            double [] price = { 10.2,30.4,50.7};

            Demo.Array(number);
            Demo.Array(name);
            Demo.Array(price);

            Console.WriteLine(Demo.check(10, 20));
            Console.WriteLine(Demo.check(10, 10));
            Console.WriteLine(Demo.check("Ali", "Ali"));
            Console.WriteLine(Demo.check("Ali", "Ahmed"));
            Console.WriteLine(Demo.check('A', 'B'));
            Console.WriteLine(Demo.check('B', 'B'));
        }
    }
}

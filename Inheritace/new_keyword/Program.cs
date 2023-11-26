using System;

namespace new_keyword
{
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }*/

    
    /* public class BaseC
     {
         public static int x = 55;
         public static int y = 22;
     }

     public class DerivedC : BaseC
     {
         // Hide field 'x'.
        new public static int x = 100;

         static void Main()
         {
             // Display the new value of x:
             DerivedC c = new DerivedC();
             Console.WriteLine(x);

             // Display the hidden value of x:
            // Console.WriteLine(BaseC.x);

             // Display the unhidden member y:
             Console.WriteLine(y);
             Console.ReadLine();

         }
     }*/

    //In this example, a nested class hides a class that has the same name in the base class
    public class BaseC
    {
        public class NestedC
        {
            public int x = 200;
            public int y;
        }
    }

    public class DerivedC : BaseC
    {
        // Nested type hiding the base type members.
        public class NestedC
        {
            new public int x = 100;
            public int y;
            public int z;
        }

        static void Main()
        {
            // Creating an object from the overlapping class:
            NestedC c1 = new NestedC();

            // Creating an object from the hidden class:
            BaseC.NestedC c2 = new BaseC.NestedC();

            Console.WriteLine(c1.x);
            Console.WriteLine(c2.x);
            Console.ReadLine();
        }
    }
}

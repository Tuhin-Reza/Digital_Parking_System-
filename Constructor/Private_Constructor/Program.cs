using System;

namespace Private_Constructor
{
    /* public class Geeks
     {
         private Geeks()
         { }
         public static int count_geeks;
         public static int geeks_Count()
         {
             return ++count_geeks;
         }
         public static void Main()
         {

             // If you uncomment the following
             // statement, it will generate
             // an error because the constructor
             // is unaccessible:
             // Geeks s = new Geeks(); // Error

             Geeks.count_geeks = 99;

             // Accessing without any
             // instance of the class
             Geeks.geeks_Count();

             Console.WriteLine(Geeks.count_geeks);

             // Accessing without any
             // instance of the class
             Geeks.geeks_Count();

             Console.WriteLine(Geeks.count_geeks);
         }
     }*/

    class Program
    {
        private Program()
        {
            Console.WriteLine("this is private constructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("main method");
            Console.ReadKey();
        }
    }
}

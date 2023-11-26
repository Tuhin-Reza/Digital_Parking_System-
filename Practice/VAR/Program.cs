using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR
{
    class Program
    {
        static void Main(string[] args)
        {
            // int value  
            var age = 30;
            Console.WriteLine("var holds an int = {0}", age);
            // string value  
            var name = "Cecilia Hansen";
            Console.WriteLine("var holds a string = {0}", name);

            // array value  
            var odds = new[] { 11, 13, 15, 17, 19 };
            Console.WriteLine("var holds an array of numbers");
            foreach (var num in odds)
            {
                Console.WriteLine("{0}", num);
            }
            // for statement
            for (var x = 1; x < 10; x++)
            {
                Console.WriteLine(x);
            }

            ///C# Var Variable Restrictions

            var p = 10; // valid

            //var y; y = 10; // Error: Implicitly-typed variables must be initialized

            //var z = null; // Error: Cannot assign null to implicitly typed variable

        }
    }
}

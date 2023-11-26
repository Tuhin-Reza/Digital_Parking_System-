using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_vs_out
{
    class Program
    {

        public static void PassByValue(int value)
        {
            value = value + 50;
            Console.WriteLine(value);
        }


        public static void PassByRef(ref int value)
        {
            value = value + 50;
            Console.WriteLine(value);
        }

        public static void PassByOut(out int value)
        {
            value = 9;//Mandatory
            value = value + 50;
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            ///Pass By Value

           // int value = 10; -> for pass by value & ref mandatory
            //PassByValue( value);
            //// Program.PassByValue(value); Also Ok
            //Console.WriteLine(value);

            //PassByRef(ref value);
            //// Program.PassByRef(value); 
            //Console.WriteLine(value);

            int value;
            PassByOut(out value);
            // Program.PassByRef(value); 
            Console.WriteLine(value);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // string a = "Ahmed","Khan"; Invalid

            //Initialize a array items during declaration
            int[] arr1 = new int[5];
            arr1[0] = 11;
            arr1[1] = 22;
            arr1[2] = 33;
            arr1[3] = 44;
            Console.Write(" "+arr1[0]);
            Console.Write(" "+arr1[1]);
            Console.Write(" "+arr1[2]);
            Console.Write(" "+arr1[3]);

            Console.WriteLine(" " +arr1[4]);//output=0

            // string[] arr2 = new string[];// This is Error declaring 
            string[] arr2 = new string[5];
            arr2[0] = "Hassan1";
            arr2[1] = "Khan";
            arr2[2] = "Ahmed";
            arr2[3] = "Ali";
            Console.Write(" " + arr2[0]);
            Console.Write(" " + arr2[1]);
            Console.Write(" " + arr2[2]);
            Console.Write(" " + arr2[3]);

            Console.WriteLine(" " + arr2[4]);//output = given 1 Blank space

            //Console.WriteLine(" " + arr2[5]);//.IndexOutOfRangeException
            //The next code will not be run

            //Code declares and initializes an array of 4 string items.
            string[] arr4 = new string[4] { "Hassan2", "Khan", "Ahmed", "Ali" };
            foreach (string item in arr4)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();

            //Initialize a dynamic length array as follows,
            string[] arr5 = new string[] { "Mahesh", "Mike", "Raj", "Praveen", "Dinesh" };
            foreach (string item in arr5)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.Write(" 1"+ arr5[0]);
            Console.Write(" " + arr5[1]);
            Console.Write(" " + arr5[2]);
            Console.Write(" " + arr5[3]);
            Console.WriteLine(" " + arr5[4]);

           //Even directly assign these values without using the new operator.
            string[] arr6 = { "Hassan3", "Khan", "Ahmed", "Ali" }; 
            for (int i = 0; i < arr6.Count(); i++)//arr6.Length
            {
                Console.Write(" "+arr6[i]);
            }
            Console.WriteLine();
            Console.WriteLine(" The array has {0} dimensions.", arr6.Rank);
            Console.ReadKey();
        }
    }
}

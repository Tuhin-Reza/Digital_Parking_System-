using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection///Dynamic Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[3];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 30;
            // myArray[3] = 40; Will through an Exception

            Array.Resize(ref myArray, 5); 
            myArray[3] = 40;
            myArray[4] = 50;
            //myArray[5] = 60; will through an Exception

            ///////ArrayList

            ArrayList Myarray = new ArrayList(); //Capacity will start from 0
            //ArrayList Myarray = new ArrayList(3);Capacity will start from 3
            Console.WriteLine(Myarray.Capacity);
            Myarray.Add(10);
            Console.WriteLine(Myarray.Capacity);
            Myarray.Add(10);
            Myarray.Add(20);
            Myarray.Add(30);
            Myarray.Add(40);
            Console.WriteLine(Myarray.Capacity);

            foreach (object item in Myarray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Myarray.Insert(0, 0);
            foreach (object item in Myarray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Myarray.Remove(30); Takes value
            Myarray.RemoveAt(0);//Takes index number
            foreach (object item in Myarray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

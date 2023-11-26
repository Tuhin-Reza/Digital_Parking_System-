using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements : ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter Elements           : ");
            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }

            Console.WriteLine("Entered Elements           : ");

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            double[] arr2 = new double[size];
            Console.WriteLine("Enter Elements           : ");
            for (int i = 0; i < size; i++)
            {
                double data = double.Parse(Console.ReadLine());
                arr2[i] = data;
            }
            foreach (double item in arr2)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}

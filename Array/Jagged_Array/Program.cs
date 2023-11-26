using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
    
                arr[0]= new [] {11,22,33,44,55,66,77,88};
                arr[1]= new [] {10,20,30,40,50,60,70};
                arr[2] = new[] { 1, 2, 3, 4, 5, 6 };

                Console.WriteLine( arr[0][4]);

                for (int i = 0; i < arr.GetLength(0); i++)//GetLength(int): returns the number of elements in the first dimension of the Array.
            {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                       Console.Write(arr[i][j]+" ");
                    }
                    Console.WriteLine();
                }

            Console.WriteLine();

            foreach (int [] item in arr)
                {
                    foreach (int i in item)
                    {
                        Console.Write(i+" ");
                    }
                    Console.WriteLine();
                }
            Console.WriteLine();


            int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
                              new int[] { 2, 4, 6, 8 } };
            foreach (int[] item in arr1)
            {
                foreach (int i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            int[][,] arr4 = new int[3][,] {new int[, ] {{1, 3}, {5, 7}},
                                           new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                           new int[, ] {{11, 22}, {99, 88}, {0, 9}}};

            for (int i = 0; i < arr4.Length; i++)
            {
                //int x = 0;
                for (int j = 0; j < arr4[i].GetLength(0); j++)
                {
                    for (int k = 0; k < arr4[j].Rank; k++)
                        Console.Write(" arr4[" + i + "][" + j + ", " + k + "]:"
                                                       + arr4[i][j, k] + " ");
                    Console.WriteLine();
                }
              //  x++;
                Console.WriteLine();
            }




        }
    }
}

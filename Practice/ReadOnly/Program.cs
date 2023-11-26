using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Program
    {
        public int x;
        // Initialize a readonly field
        public readonly int y = 25;
        public readonly int z;

        public Program()
        {
            // Initialize a readonly instance field
            z = 24;
        }

        public Program(int p1, int p2, int p3)
        {
            x = p1;
            y = p2;
            z = p3;
        }

        public static void Main()
        {
            Program p1 = new Program(11, 21, 32);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;// OK
            Console.WriteLine("p1: x={"+p1.x+"}, y={"+p1.y+"}, z={"+p1.z+"}");
            Program p2 = new Program();
            p2.x = 55;   // OK
            //p2.y = 55;   // Error as ReadOnly
            Console.WriteLine("p2: x={" + p2.x + "}, y={" + p2.y + "}, z={"+p2.z+"}");
            // readonly int k=0;
           Console.WriteLine("");
    }
    }
 }


using System;
using System.Collections.Generic;

namespace Task_C
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringlist = new List<string>();
            stringlist.Add("AA");
            stringlist.Add("BB");
            stringlist.Add("BB");
            stringlist.Add("CC");
            stringlist.Add("DD");
            stringlist.Add("EE");
            Console.Write("Enter Any Word :");
            String spell = Console.ReadLine();
            int c = 0;
            foreach (string item in stringlist)
            {
                if (spell.Equals(item))
                {
                    Console.Write("Spelling is write");
                    c++;
                }
            }
            if (c== 0)
            {
                Console.Write("Spelling Wrong Please try Again");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}

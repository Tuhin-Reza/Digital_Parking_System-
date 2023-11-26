using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Function
{
    class Example
    {
        public void cout(int a) { Console.WriteLine("int"); }
        public void cout(int a, int b) { Console.WriteLine("int,int"); }
        public void cout(string a) { Console.WriteLine("string"); }
        public void cout(string a, int b) { Console.WriteLine("string,int"); }
        public void cout(int a, string b) { Console.WriteLine("int,string"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            e.cout(5);
            e.cout(5, 5);
            e.cout("5");
            e.cout("5", 5);
            e.cout(5, "5");
        }
    }
}

using System;

namespace Static_Constructor
{
    class Example
    {
        int i;
        static int j;
        public Example()
        {
            i = 10;
        }
        static Example()
        {
            
            j = 20;
        }
        public void Display()
        {
            Console.WriteLine("value of i : " + i);
            i++;
            Console.WriteLine("value of j : " + j+"\n");
            j++;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Example e1 = new Example();
            e1.Display();
            e1.Display();
            Example e2 = new Example();
            e2.Display();
            e2.Display();
            Console.ReadKey();
        }
    }
}

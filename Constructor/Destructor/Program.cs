using System;

namespace Destructor
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("constructor object created");
        }
        ~DestructorDemo()
        {
            Console.WriteLine("object is destroyed");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            DestructorDemo obj1 = new DestructorDemo();
            DestructorDemo obj2 = new DestructorDemo();
            obj1 = null;
            obj2 = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}

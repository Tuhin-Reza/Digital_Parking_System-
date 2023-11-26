using System;

namespace Using_base_class_Constructor_1
{
    public class clssA
    {
  
        int n1, n2;
        public clssA()
        {
            Console.WriteLine("Default Constructor Invoked");
        }

        public clssA(int i, int j)
        {
            n1 = i;
            n2 = j;
            Console.WriteLine("Parameterized Constructor Invoked");
            Console.WriteLine("Invoked Values are: " + n1 + " and " + n2);
        }
    }

    public class DerivedClass : clssA
    {
        public DerivedClass() : base() 
        { 
            Console.WriteLine("Default Constructor Invoked2.1"); 
        }
        public DerivedClass(int i, int j) : base(i,j)
        { 
            Console.WriteLine("Default Constructor Invoked2.2 : "+ (i+j));
        }

        static void Main()
        {
            Console.WriteLine();
            clssA d = new DerivedClass();
           // DerivedClass d5 = new clssA();
            DerivedClass d1= new DerivedClass();
            DerivedClass d2 = new DerivedClass(10, 20);
        }
    }
}

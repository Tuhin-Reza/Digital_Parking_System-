using System;

namespace Use_base_class_Constructor_2
{
    public class clssA
    {
        public int n1, n2;
        public clssA()
        {
            Console.WriteLine("In clssA 'no argument constructor' invoked");
        }

        public clssA(int i, int j)
        {

            // consturct values
            n1 = i;
            n2 = j;
            Console.WriteLine("in clssA 'parameterized constructor' invoked");
            Console.WriteLine("the invoked values are " + n1 + " and " + n2);
            Console.WriteLine();
        }

        public virtual void swap()
        {
            Console.WriteLine("swap function of base class(clssA) invoked");
            Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);

            // swapping
            int t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
        }
    }

    // derived class
    public class DerivedClass : clssA
    {

        // This constructor will instantiate
        // 'clssA' [no argument constructor]
        // using 'base' keyword
        public DerivedClass() { }

        // This constructor will instantiate 
        // 'clssA' [parameterized constructor]
        // using 'base' keyword
        public DerivedClass(int i, int j) : base(i, j) { }

        public override void swap()
        {

            // it access the swap function of
            // 'clssA' using 'base' keyword
            base.swap();

            Console.WriteLine();

            Console.WriteLine("Swap function of derived class invoked");
            Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);

            // swapping
            int t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
        }

        // Main Method
        static void Main()
        {

            // invoke no argumanet constructor
           // clssA obj = new clssA();
          //  obj.swap();

            Console.WriteLine();

            // invoke parameterized constructor
            DerivedClass d2 = new DerivedClass(10, 20);

            // calling swap function
            d2.swap();

        }
    }
}

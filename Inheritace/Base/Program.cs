using System;

namespace Base
{
    public class BaseClass
    {
        int num;

        public BaseClass()
        {
            Console.WriteLine("Based Class Called");
        }

        public BaseClass(int i)
        {
            num = i-1;
            Console.WriteLine("Number : "+num);
        }

        public int GetNum()
        {
            return num;
        }
    }

    public class DerivedClass : BaseClass
    {
        // This constructor will call BaseClass.BaseClass()
        public DerivedClass() : base()
        {
            Console.WriteLine("Derive Class Called");
        }

        // This constructor will call BaseClass.BaseClass(int i)
        public DerivedClass(int i) : base(i)
        {
            Console.WriteLine("Number : "+i);
        }

        static void Main()
        {
            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(2);
            Console.WriteLine("Number : " +md.GetNum());
        }
    }
}

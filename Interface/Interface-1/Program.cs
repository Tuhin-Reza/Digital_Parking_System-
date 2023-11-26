using System;

namespace Interface_1
{
    /*public interface A
    {
        void method1();
        void method2();
    }
    interface B : A
    {
        void method3();
    }
    class MyClass : B
    {
        public void method1()
        {
            Console.WriteLine("implement method1");
        }
        public void method2()
        {
            Console.WriteLine("implement method2");
        }
        public void method3()
        {
            Console.WriteLine("implement method3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.method1();
            obj.method2();
            obj.method3();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }*/

    // Example2: WAP TO CALCULATE AREA OF RECTANGLE, CIRCLE USING INTERFACE.

     interface Area
    {
        void area(double a, double b);
    }
    class Rectangle : Area
    {
        public void area(double a, double b)
        {
            double areaRectangle;
            areaRectangle = a * b;
            Console.WriteLine("the area of rectangle is :" + areaRectangle);
        }
    }
    class Circle : Area
    {
        static double PI = 3.14;
        public void area(double a, double b)
        {
            double areaCircle;
            areaCircle = PI * a * a;
            Console.WriteLine("the area of Circle is :" + areaCircle);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Area a = new Rectangle();
           // a.area(5, 6);
            a = new Circle();
            a.area(7, 0);
          
            Console.ReadKey();
        }
    }
}

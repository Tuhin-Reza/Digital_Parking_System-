using System;

namespace Constructor_Overlodding
{
    /* class ConstructorOverloading
     {
         int x;
         public ConstructorOverloading()
         {
             this.x = 10;
         }
         public ConstructorOverloading(int x)
         {
             this.x = x;
         }
         public void Display()
         {
             Console.WriteLine("the value of x:{0}", x);
         }
     }
     class Test
     {
         static void Main(string[] args)
         {
             ConstructorOverloading obj1 = new ConstructorOverloading();
             ConstructorOverloading obj2 = new ConstructorOverloading(20);
             obj1.Display();
             obj2.Display();
             Console.ReadKey();
         }
     }*/


    /* class GFG   //Invoke an Overloaded Constructor using “this” keyword
     {
         private int Length, Height;
         private double Width;
         public GFG()
         {
             Console.WriteLine("Default Constructor Invoked");
         }
         public GFG(int l, double w) : this()
         {
             Console.WriteLine("Parameterized Constructor in 2nd Constructor");

             // assigning value of  
             // 'Length'and 'Width' 
             Length = l;
             Width = w;

         }
         public GFG(int l, double w, int h) : this(l, w)
         {
             Console.WriteLine("Parameterized Constructor in 3rd Constructor");

             // assign value of 'Height' 
             Height = h;

         }
         public double Volume()
         {
             return (Length * Width * Height);
         }
     }

     // Driver Class 
     class Geeks
     {
         public static void Main()
         {

             // Invoking 3rd Constructor 
             // here Constructor chaining 
             // came into existence 
             // GFG g = new GFG(10, 20.5, 30);
             GFG g = new GFG(10, 20.5);

             // calling the 'Volume' Method 
             Console.WriteLine("Volume is : {0}", g.Volume());
             Console.ReadLine();

         }
     }*/

    // Example 2:
    // Constructor with parameters 
    /*class Geek
    {
        // Constructor with parameters 
        public Geek(int a, double b, string c)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        // Constructor with parameters 
        // Here this keyword is used  
        // to call Geek constructor 
        public Geek(int a, int b): this(50, 2.9, "Hello")
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    // Driver Class 
    public class GFG
    {

        // Main method 
        static public void Main()
        {

            // Create oject of Geek class 
            Geek obj = new Geek(15, 30);
        }
    }*/

    //Example: 3
    class User
    {
        // public User():this("","")
        public User()
        {
            Console.Write("Hi! ");
        }
        public User(string a) : this()
        {
            Console.Write(a);
        }
        public User(string a, string b) : this("welcome")
        {
            Console.Write(a + " " + b);
        }
    }

    class Student : User
    {
        public Student() : base("", "to ")
        {
            Console.Write("CS Department. ");
        }
        public Student(string a) : this("", "Proud ")
        {
            Console.Write(a);
        }
        public Student(string a, string b)
        {
            Console.Write(a + " " + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User u = new User(" to", "AIUB");
            Console.WriteLine();
            Student s = new Student();
            Console.WriteLine();
            Student s2 = new Student("AIUBIAN");
            Console.WriteLine();
        }
    }
}

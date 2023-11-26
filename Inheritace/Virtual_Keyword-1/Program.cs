using System;

namespace Virtual_Keyword_1
{
    /* public class Shape
     {
         public const double PI = Math.PI;
         protected double x, y;

         public Shape()
         {
             Console.WriteLine("Default Shape");
         }

         public Shape(double x, double y)
         {
             this.x = x;
             this.y = y;
             Console.WriteLine("Shape");
         }

         public virtual double Area()
         {
             return x * y;
         }
     }

     public class Circle : Shape
     {
         public Circle()
         {
             Console.WriteLine("Default Circle");
         }
         public Circle(double r) : base(r, 0)
         {
             Console.WriteLine("Circle");
         }

        public override double Area()
         {
             return PI * x * x;
         }
     }

     class Sphere : Shape
     {

         public Sphere()
         {
             Console.WriteLine("Default Sphere");
         }
         public Sphere(double r) : base(r, 0)
         {
             Console.WriteLine("Sphere");
         }

         public override double Area()
         {
             return 4 * PI * x * x;
         }
     }

     class Cylinder : Shape
     {
         public Cylinder()
         {
             Console.WriteLine("Default Cylder");
         }
         public Cylinder(double r, double h) : base(r, h)
         {
         }

         public override double Area()
         {
             return 2 * PI * x * x + 2 * PI * x * y;
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             double r = 3.0, h = 5.0;
            Circle c = new Circle(r);
            //Shape s = new Sphere(r);
             //Shape l = new Cylinder(r, h);
             // Display results.
             Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
           // Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            // Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
             Console.ReadLine();
         }
     }*/

    //Invoked Virtual Method that override and not override in derived classes
    class Shape
    {
        public double length = 0.0;
        public double width = 0.0;
        public double radius = 0.0;

        public Shape(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Shape(double radius)
        {
            this.radius = radius;
        }

        public virtual void Area()
        {
            double area = 0.0;
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of Shape is :{0:0.00} ", area);
        }
    }

    class Rectangle : Shape
    {

        public Rectangle(double length, double width) : base(length, width)
        {
        }

        public override void Area()
        {
            double area = 0.0;
            area = length * width;
            Console.WriteLine("Area of Rectangle is :{0:0.00} ", area);
        }
    }
    class Circle : Shape
    {
        public Circle(double radius): base(radius)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double length, width, radius = 0.0;
            Console.WriteLine("Enter the Length");
            length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width");
            width = Double.Parse(Console.ReadLine());
            Rectangle objRectangle = new Rectangle(length, width);
            objRectangle.Area();

            Console.WriteLine("Enter the Radius");
            radius = Double.Parse(Console.ReadLine());
            Circle objCircle = new Circle(radius);
            objCircle.Area();
            Console.ReadLine();
        }
    }
}

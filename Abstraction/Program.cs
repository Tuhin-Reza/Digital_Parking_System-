using System;

namespace Abstraction
{
    abstract  class Shape
    {      
        public abstract int area();// abstract method 
    }
    class Square : Shape
    {
        private int side;
        public Square(int x = 0)
        {
            side = x;
        }
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    class GFG
    {
        static void Main(string[] args)
        {

            // creating reference of Shape class 
            // which refer to Square class instance 
            Shape sh = new Square(4);

            // calling the method 
            double result = sh.area();

            Console.Write("{0}", result);
            Console.Read();

        }
    }
} 


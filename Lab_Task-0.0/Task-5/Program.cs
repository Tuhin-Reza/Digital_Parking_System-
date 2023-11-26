using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height, area, perimeter;
            Console.Write("Enter Length : ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter Width : ");
            width = Convert.ToInt32(Console.ReadLine());
            area = height * width;
            perimeter = 2 * (height + width);
            Console.WriteLine("\n\nArea of  That Rectangle     : " + area);
            Console.WriteLine("Perimeter of that Rectangle : " + perimeter);
            Console.ReadKey();

        }
    }
}

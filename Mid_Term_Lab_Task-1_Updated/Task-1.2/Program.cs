using System;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tn1 = new Triangle(10,20,30);

            Triangle tn2= new Triangle();
            tn2.X=10;
            tn2.Y=10;
            tn2.Z=10;

            Triangle tn3 = new Triangle();
            tn3.setx(100);
            tn3.sety(20);
            tn3.setz(100);

            tn1.ShowInfo();
            tn2.ShowInfo();
            tn3.ShowInfo();

            Console.ReadKey();
        }
    }
}

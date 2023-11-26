using System;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tn1 = new Triangle();
            tn1.setx(10);
            tn1.sety(20);
            tn1.setz(30);

            Triangle tn2= new Triangle();
            tn2.setx(10);
            tn2.sety(10);
            tn2.setz(10);

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

using System;

namespace Task_1._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Course c1 = new Course();
            c1.setcourName("OOP2");
            c1.setcourseCode("2201");
            c1.setcourCredit(3);

            Course c2 = new Course();
            c2.setcourName("Data Structure");
            c2.setcourseCode("1101");
            c2.setcourCredit(4);

            c1.ShowInfo();
            c2.ShowInfo();
            Console.ReadKey();
        }
    }
}

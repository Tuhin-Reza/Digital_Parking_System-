using System;

namespace Task_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course("OOP1", "5050", 4);

            Course c2 = new Course();
            c2.Name=("OOP2");
            c2.Code=("2201");
            c2.Credit=(3);

            Course c3 = new Course();
            c3.setcourName("Data Structure");
            c3.setcourseCode("1101");
            c3.setcourCredit(4);

            c1.ShowInfo();
            c2.ShowInfo();
            c3.ShowInfo();
            Console.ReadKey();
        }
    }
}

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course("OOP1", "5050", 4);

            Course c2 = new Course();
            c2.Name = ("OOP2");
            c2.Code = ("2201");
            c2.Credit = (3);
            
            c1.ShowInfo();
            c2.ShowInfo();
           
            Console.ReadKey();
        }
    }
}

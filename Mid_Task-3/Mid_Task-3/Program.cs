using System;

namespace Mid_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1= new Course("OOP1","1002");
            Course c2 = new Course("OOP2","2002");

            Student s1 = new Student("AAAA","20-1");
            Student s2 = new Student("BBBB","20-2");

            c1.ShowInfo();
            s1.ShowInfo();

            c1.AddStudent(s1);
            c1.AddStudent(s2);
            c1.ShowInfo();
            c1.Remove(s1);
            c1.ShowInfo();

            s1.AddCourse(c1);
            s1.AddCourse(c2);
            s1.ShowInfo();
            s1.DropCourse(c1);
            s1.ShowInfo();




            Console.ReadKey();
        }
    }
}

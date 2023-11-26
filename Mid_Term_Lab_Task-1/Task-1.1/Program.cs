using System;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 =new Student();
            Student st2 = new Student();
            st1.setname("Tom");
            st1.setid("20-39074-3");
            st1.setdepartment("Bsc & CSE");
            st1.setcgpa(3.99f);

            st2.setname("Jerry");
            st2.setid("20-39074-1");
            st2.setdepartment("Bsc & CSSE");
            st2.setcgpa(3.50f);
            st1.ShowInfo();
            st2.ShowInfo();
            Console.ReadKey();

        }
    }
}

using System;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st1 =new Student();
            Student st2 = new Student();
            Student st3 = new Student("Ogy", "20-39074-2", "EEE", 3.01f);


            st1.setname("Tom");
            st1.setid("20-39074-3");
            st1.setdepartment("Bsc & CSE");
            st1.setcgpa(3.99f);

            st2.Name="Jerry";
            st2.Id="20-39074-1";
            st2.Department="Bsc & CSSE";
            st2.Cgpa=3.50f;

            st1.ShowInfo();
            st2.ShowInfo();
            st3.ShowInfo();
            GC.Collect();

            Console.ReadKey();

        }
    }
}

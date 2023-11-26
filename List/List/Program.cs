using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mynumbers = new List<int>();//Strongly typed
            mynumbers.Add(10);
            mynumbers.Add(11);
            mynumbers.Add(12);
            Console.WriteLine(mynumbers.Capacity);//This property tells capacity
            mynumbers.Add(13);
            mynumbers.Add(14);
            Console.WriteLine(mynumbers.Capacity);//This property tells capacity
            mynumbers.Add(15);
            mynumbers.Add(16);
            mynumbers.Add(17);
            mynumbers.Add(18);
            Console.WriteLine(mynumbers.Capacity);//This property tells capacity
            //mynumbers.Add(""); Invalid as should be int 

            foreach(int item in mynumbers)
            {
                Console.WriteLine(item);
            }

            List<string> mynames = new List<string>();//Strongly typed
            mynames.Add("A");
            mynames.Add("B");
            mynames.Add("C");
            mynames.Add("D");
            foreach (string item in mynames)
            {
                Console.WriteLine(item);
            }


            Student s1 = new Student { Name = "Ahmed", Id = 101 };
            Student s2 = new Student { Name = "Khan ", Id = 102 };
            Student s3 = new Student { Name = "Ali  ", Id = 103 };
            Student s4 = new Student { Name = "Akber", Id = 104 };


            List<Student> StuList = new List<Student>();///Complex type
            StuList.Add(s1);
            StuList.Add(s2);
            StuList.Add(s3);
            StuList.Add(s4);

            foreach (Student stu in StuList)
            {
                Console.WriteLine("Student Name is : {0} & Age is : {1}", stu.Name, stu.Id);
            }
        }
    }
}

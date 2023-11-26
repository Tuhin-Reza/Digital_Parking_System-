using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._1
{
    class Student
    {
        String name;
        String id;
        string department;
        float cgpa;
        public void setname(string newname)
        {
            name = newname;
        }
        public void setid(string newid)
        {
            id = newid;
        }
        public void setdepartment(string newdepartment)
        {
            department = newdepartment;
        }
        public void setcgpa(float newcgpa)
        {
            cgpa = newcgpa;
        }
        public String getname()
        {
            return name;
        }
        public String getid()
        {
            return id;
        }
        public string getdepartment()
        {
            return department;
        }
        public float getcgpa()
        {
            return cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("\n---------Student Information---------");
            Console.WriteLine("\nStudent Name       : " + name);
            Console.WriteLine("Student ID         : " + id);
            Console.WriteLine("Student Department : " + department);
            Console.WriteLine("Student CGPA       : " + cgpa);
        }
    }
}

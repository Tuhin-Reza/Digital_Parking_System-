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
        ~Student()
        {
            Console.WriteLine("Default cnstructor Called");
        }
        public Student()
         {
             Console.WriteLine("Default cnstructor Called");
         }
       
        public Student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }
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
          public string Name
          {
              get { return name; }
              set { name = value; }
          }
          public string Id
          {
              get { return id; }
              set { id = value; }
          }
          public string Department
          {
              get { return department; }
              set { department = value; }
          }
          public float Cgpa
          {
              get { return cgpa; }
              set { cgpa = value; }
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Task_3
{
    class Student
    {
        String s_name;
        String s_id;
        Course[] listOfCourse;
        int CourseCounter = 0;
        public Student() { }
        public Student(string name, string id)
        {
            this.s_name = name;
            this.s_id = id;
            listOfCourse = new Course[5];
        }
      
        public string Name
        {
            get { return s_name; }
            set { s_name = value; }
        }
        public string Id
        {
            get { return s_id; }
            set { s_id = value; }
        }
    
       
        public void ShowInfo()
        {
            if (CourseCounter!=0)
            {
                for (int i = 0; i < CourseCounter; i++)
                {
                    Console.WriteLine("\n---------Student Information---------");
                    Console.WriteLine("\nStudent Name     : " + s_name);
                    Console.WriteLine("Student ID       : " + s_id);
                    Console.WriteLine("\nCourse Name      : " + listOfCourse[i].Name);
                    Console.WriteLine("Course Code      : " + listOfCourse[i].Code);
                }
            }
            else
            {
                Console.WriteLine("\n--->Student can not Find anyInformation");
            }
           
        }
        public void AddCourse(Course cou)
        {
            if (CourseCounter <= 5)
            {
                listOfCourse[CourseCounter] = cou;
                Console.WriteLine("\n--->Student Added New Course Code:" + listOfCourse[CourseCounter].Code);
                CourseCounter++;
            }
            else
            {
                Console.WriteLine("Student can Not Added New Course");
            }
        }
        public void DropCourse(Course cou)
        {
            bool deleted = false;
            for (int i = 0; i < CourseCounter-2; i++)
            {
                if (cou == listOfCourse[i])
                {
                    Console.WriteLine("\n--->Student Drop Course Code : " + listOfCourse[i].Code);
                    listOfCourse[i] = listOfCourse[--CourseCounter];
                    deleted = true;
                }
            }
            if (!deleted)
            {
                Console.WriteLine("\n--->Student can not Drop The Course");
            }

        }

    }
}


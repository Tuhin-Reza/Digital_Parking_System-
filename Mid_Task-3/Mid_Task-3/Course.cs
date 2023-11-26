using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Task_3
{
    class Course
    {
        String courseName;
        String courseCode;

        Student[] listOfStudent;
        int total_Student = 0;

        public Course() { }

        public Course(string courseName, string courseCode)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            listOfStudent = new Student[30];
        }

        public string Name
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string Code
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
       
        public void ShowInfo()
        {
            if (total_Student != 0)
            {
                for (int i = 0; i < total_Student; i++)
                {
                    Console.WriteLine("\n\n--------Course Information---------");
                    Console.WriteLine("\nCourse Name         : " + courseName);
                    Console.WriteLine("Course Code         : " + courseCode);
                    Console.WriteLine("\nStudent Name        : " + listOfStudent[i].Name);
                    Console.WriteLine("Student ID          : " + listOfStudent[i].Id);
                }
            }
            else
            {
                Console.WriteLine("--->Course can not Find anyInformation");
            }                  
        }
        public void AddStudent(Student stu)
        {
            if (total_Student <= 30)
            {
                listOfStudent[total_Student] = stu;
                listOfStudent[total_Student] = stu ;
                Console.WriteLine("\n--->Course Added New student Id :" + listOfStudent[total_Student].Id);
                total_Student++;
            }
            else
            {
                Console.WriteLine("Course Can Not Added New Student");
            }
        }
        public void Remove(Student stu)
        {
            bool deleted = false;
            for (int i = 0; i < total_Student; i++)
            {
                if (stu==listOfStudent[i])
                {
                    Console.WriteLine("\n---> Course Remove Student Id : " + listOfStudent[i].Id);
                    listOfStudent[i] = listOfStudent[--total_Student];
                    deleted = true;
                }
            }
            if (!deleted)
            {
                Console.WriteLine("--->Course Can not Remove  Student");
            }

        }
    } 
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Course
    {
        String courseName;
        String courseCode;
        int courseCredit;

        public Course()
        {
            Console.WriteLine("Default cnstructor Called");
        }
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
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
        public int Credit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }   
        public void ShowInfo()
        {

            Console.WriteLine("\n\n--------Course Information---------");
            Console.WriteLine("\nCourse Name         : " + courseName);
            Console.WriteLine("Course Code         : " + courseCode);
            Console.WriteLine("Course Credit       : " + courseCredit);

        }
    }
}

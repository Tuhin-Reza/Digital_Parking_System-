using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._4
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

        public void setcourName(string newname)
        {
            courseName = newname;
        }
        public void setcourseCode(string newcourseCode)
        {
            courseCode = newcourseCode;
        }
        public void setcourCredit(int newcourseCredit)
        {
            courseCredit = newcourseCredit;
        }
        public String getcoursename()
        {
            return courseName;
        }
        public String getcourseCode()
        {
            return courseCode;
        }
        public int getcourseCredit()
        {
            return courseCredit;
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

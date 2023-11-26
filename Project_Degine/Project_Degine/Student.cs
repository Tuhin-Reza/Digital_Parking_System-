using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Degine
{
    class Student
    {
        Staff[] listofstaff = new Staff[50];
        string course_name;
        int id;
        string name;
        string attendence;
        string cause;
        string departmnet;
       
      

        public Student()
        {
            
        }
        public Student(string course_name,string name,int id)
        {
            this.course_name = course_name;
            this.name = name;
            this.id = id;
        }

        public string Course_name
        {
            get { return course_name; }
            set { course_name = value; }
        }
        public string Name
        {
            get{ return name; }
            set{ name = value; }
            
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Cause
        {
            get { return cause; }
            set { cause = value; }

        }
        public string Department
        {
            get { return departmnet; }
            set { departmnet = value;}
        }
        public string Attendence
        {
            get { return attendence; }
            set { attendence = value; }
        }


        public void appllyLeave() 
        {
            Console.WriteLine("----------Leave Apply Information----------\n");
            Console.WriteLine("Student  Course Name       : " + course_name);
            Console.WriteLine("Student  Name              : " + name);
            Console.WriteLine("Student  ID                : " + id);
            Console.WriteLine("Leave    Cause             : " + cause+"\n");
            Console.WriteLine("----------Processing leave application ----------\n");
        }
       public void appplyComplain(Student stud1)
       {
            Console.WriteLine("----------Apply Complain Information----------\n");
            Console.WriteLine("Student  Course Name       : " + departmnet);
            Console.WriteLine("Student  Name              : " + name);
            Console.WriteLine("Student  ID                : " + id);
            Console.WriteLine("Complain Cause             : " +  cause+ "\n");
            Console.WriteLine("----------Processing Complain application ----------\n");

        }
       public  void viewAttendence() 
        {

        }


    }
}

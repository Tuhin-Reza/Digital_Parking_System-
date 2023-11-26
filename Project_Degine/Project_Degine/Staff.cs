 using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Degine
{
    class Staff
    {
        Student[] listofStudent = new Student[40];
        int totalStudent = 0;
        string course_name;
        int id;
        string name;
        string attendence;
        String decision;

        public Staff()
        {

        }
        public Staff(string course_name, string name, int id)
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
        get { return name; }
        set { name = value; }    
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Attendence
        {
            get { return attendence; }
            set { attendence = value; }
        }
        public string Decision
        {
            get { return decision; }
            set { decision = value; }

        }

        public void addStudent(Student student)
        {
            if (totalStudent <= 40)
            {
                listofStudent[totalStudent] = student;
                Console.WriteLine("\n--->Added New Student ID:" + listofStudent[totalStudent].Id);
                totalStudent++;
            }
            else
            {
                Console.WriteLine("--->Can Not Added New Student\n");
            }
        }
        public void addAttendence(string attendence)
        {
            for (int i = 0; i < totalStudent; i++)
            {
                listofStudent[i].Attendence = attendence;
                //Console.WriteLine(listofStudent[i].Course_name + "\t" + listofStudent[i].Id + "\t" + listofStudent[i].Name + "\t" + listofStudent[i].Attendence);
            }

        }
        public void modifyAttendence(Student stud)
        {
            /*Console.WriteLine("Enter Student Id Whose attendance you want to modify ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Attendence");
            attendence = Console.ReadLine();
            for (int i = 0; i <totalStudent; i++)
            {
                if (listofStudent[i].Id == id)
                {
                    listofStudent[i].Attendence = attendence;
                }

            }*/
            for (int i = 0; i < totalStudent; i++)
            {
                if (stud == listofStudent[i])
                {
                    Console.WriteLine("Enter Student Attendence");
                    attendence = Console.ReadLine();
                    listofStudent[i].Attendence = attendence;
                    Console.WriteLine("\n----------Modified Attendence----------\n");
                }
                else
                {
                    Console.WriteLine("--->Can Not Modified Student Attendence\n");
                }
            }

        }
        public void viewAttendence()
        {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.WriteLine(listofStudent[i].Course_name + "\t" + listofStudent[i].Id + "\t" + listofStudent[i].Name + "\t" + listofStudent[i].Attendence);
            }
        }
        public void manageLeave(Student stud1)
        {
            Console.WriteLine("----------Student Apply Leave Information----------\n");
            Console.WriteLine("Student  Course Name       : " + stud1.Course_name);
            Console.WriteLine("Student  Name              : " + stud1.Name);
            Console.WriteLine("Student  ID                : " + stud1.Id);
            Console.WriteLine("Leave    Cause             : " + stud1.Cause + "\n");
            Console.WriteLine("-\tEnter Your Decision-");
            decision = Console.ReadLine();
        }
        public void manageComplain(Student stud2)
        {
            Console.WriteLine("----------Student Apply Complain Information----------\n");
            Console.WriteLine("Student  Course Name       : " + stud2.Department);
            Console.WriteLine("Student  Name              : " + stud2.Name);
            Console.WriteLine("Student  ID                : " + stud2.Id);
            Console.WriteLine("Leave    Cause             : " + stud2.Cause + "\n");
            Console.WriteLine("We will try to give maximum importance to your subject");
        }
        public void changePassword()
        {

        }



    }

}


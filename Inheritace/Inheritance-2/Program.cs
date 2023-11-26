using System;

namespace Inheritance_2
{
    class Program
    {
        public class Person
        {
            int Id;
            string Name;
            string Address;
            string Phone;
        }
        public class Student : Person
        {
            string Class;
            string Fees;
            string Marks;
            string Grade;
        }
        public class Staff : Person
        {
            string Designation;
            double Salary;
        }
        public class Technical : Staff
        {
            string Qualification;
            string Subject;
        }
        public class NonTechnical : Staff
        {
            string Dname;
            string Superior;
        }
    }
}

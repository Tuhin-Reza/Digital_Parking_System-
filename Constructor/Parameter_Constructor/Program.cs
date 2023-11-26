using System;

namespace Parameter_Constructor
{
    class Employee
    {
        int eid, eage;
        String eaddress, ename;
        public Employee(int eid, int age, string name, string address)
        {
            this.eid = eid;
            eage = age;
            ename = name;
            eaddress = address;
        }
        public void Display()
        {
            Console.WriteLine("employee id is     :  " + eid);
            Console.WriteLine("employee name is   :  " + ename);
            Console.WriteLine("employee age is    :  " + this.eage);
            Console.WriteLine("employee address is:  " + eaddress+"\n");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, 30, "Pranaya", "Mumbai");
            Employee e2 = new Employee(102, 28, "Rout", "BBSR");
            e1.Display();
            e2.Display();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_extended
{
    class Employee
    {
        public int id;
        public string name;
        public float salary;
        public void insert(int i,string n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            e1.insert(1,"M",80);
            e2.insert(2, "N", 70);
            e3.insert(3, "O", 80);
            e1.display();
            e2.display();
            e3.display();
        }
    }
}

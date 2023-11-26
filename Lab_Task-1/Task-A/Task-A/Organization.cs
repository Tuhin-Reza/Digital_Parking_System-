using System;
using System.Collections.Generic;
using System.Text;

namespace Task_A
{
    class Organization
    {
        string empType;
        string name;
        string id;
        double balance;

        public Organization(string empType,string name,string id,double balance)
        {
            this.empType = empType;
            this.name = name;
            this.id = id;
            this.balance = balance;
        }
        public string Type
        {
            get { return empType; }
            set { empType = value; }
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
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void show()
        {
            string a="Admin";
            string b = "Manager";
            string c = "Salesaman";
            if (a.Equals(empType))
            {
                Console.WriteLine("\n-----Admin Employee Information----- \n");
                Console.WriteLine("--->Employee Type            : " + empType);
                Console.WriteLine("--->Employee Name            : " + name);
                Console.WriteLine("--->Employee Id              : " + id);
                Console.WriteLine("--->Employee Monthly Salary  : " + balance);
                Console.WriteLine("--->Employee Yearly  Salary  : " + balance * 12 + "\n");
            }
            else if (b.Equals(empType))
            {
                Console.WriteLine("\n-----Manager Employee Information----- \n");
                Console.WriteLine("--->Employee Type             : " + empType);
                Console.WriteLine("--->Employee Name             : " + name);
                Console.WriteLine("--->Employee Id               : " + id);
                Console.WriteLine("--->Employee Monthly Salary   : " + balance);
                Console.WriteLine("--->Employee Yearly  Salary   : " + balance * 12 + "\n");
            }
            else if (c.Equals(empType))
            {
                Console.WriteLine("\n-----Salesman Employee Information----- \n");
                Console.WriteLine("--->Employee Type            : " + empType);
                Console.WriteLine("--->Employee Name            : " + name);
                Console.WriteLine("--->Employee Id              : " + id);
                Console.WriteLine("--->Employee Monthly Salary  : " + balance);
                Console.WriteLine("--->Employee Yearly  Salary  : " + balance * 12 + "\n");
            }
            else {
                Console.WriteLine("-----Employee Not Avaiable-----");
            }
        }
    }
}

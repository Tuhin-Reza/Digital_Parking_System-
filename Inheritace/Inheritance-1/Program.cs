using System;

namespace Inheritance_1
{
    class Branch
    {
        int BranchCode;
        string BranchName, BranchAddress;
        protected void GetBranchData()
        {
            Console.WriteLine("ENTER BRANCH DETAILS:");
            Console.WriteLine("ENTER BRANCH CODE");
            BranchCode = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER BRANCH NAME");
            BranchName = Console.ReadLine();
            Console.WriteLine("ENTER BRANCH ADDRESS");
            BranchAddress = Console.ReadLine();
        }
        protected void DisplayBranchData()
        {
            Console.WriteLine("BRANCH CODE IS : " + BranchCode);
            Console.WriteLine("BRANCH NAME IS : " + BranchName);
            Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
        }
    }
    class Employee : Branch
    {
        int EmployeeId, EmployeeAge;
        string EmployeeName, EmployeeAddress;
        public void GetEmployeeData()
        {
            //to call the base class method use base keyword
            base.GetBranchData();
            Console.WriteLine("ENTER EMPLYEE DETAILS:");
            Console.WriteLine("ENTER EMPLOYEE ID");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE AGE");
            EmployeeAge = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER EMPLOYEE NAME");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOYEE ADDRESS");
            EmployeeAddress = Console.ReadLine();
        }
        public void DisplayEmployeeData()
        {
            base.DisplayBranchData();
            Console.WriteLine("EMPLOYEE ID IS : " + EmployeeId);
            Console.WriteLine("EMPLOYEE NAME IS : " + EmployeeName);
            Console.WriteLine("EMPLOYEE ADDRESS IS : " + EmployeeAddress);
            Console.WriteLine("EMPLOYEE AGE IS : " + EmployeeAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            //Here we cannot access the Branch class method as they are now protected
            // obj1.GetBranchData(); //Will give Compile time error
            obj1.GetEmployeeData();
            // obj1.DisplayBranchData(); // will give compile time error
            obj1.DisplayEmployeeData();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}

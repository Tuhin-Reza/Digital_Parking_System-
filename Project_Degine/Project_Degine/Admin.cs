  using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Degine
{
    class Admin :Branch
    {
        Staff[] listofstaff = new Staff[50];
        Branch[] listofbranch = new Branch[50];
        int  totalstaff=0;
        int totalbranch = 0;
       public  void addBranch(Branch branch) {
            for (int i = 0; i < listofbranch.Length; i++)
            {
                if (listofbranch[i] == null)
                {
                    listofbranch[i] = branch;
                    totalbranch++;
                    Console.WriteLine("Branch Added");
                    break;
                }
            }
        }
        public void modifyBranch(Branch branch)
        {
            for (int i = 0; i <totalbranch; i++)
            {
                if (branch == listofbranch[i])
                {
                    Console.WriteLine("Enter Modified Branch Name : ");
                    string name  = Console.ReadLine();
                    listofbranch[i].Branch_name = name;
                    Console.WriteLine("\n----------Modified Branch----------\n");
                }
                else
                {
                    Console.WriteLine("--->Can Not Modified Branch\n");
                }
            }

        }
        public void addStaff(Staff staff) 
        {
            for (int i = 0; i < listofstaff.Length; i++)
            {
                if (listofstaff[i] == null)
                {
                    listofstaff[i] = staff;
                    totalstaff++;
                    Console.WriteLine("Staff Added");
                    break;
                }
            }
        }
        public void viewAttendence()
        {
         
        }
        public new void show_Branch_details()
        {
            int i = 0;
            Console.WriteLine("Branch Name         : "+listofbranch[i].Branch_name);
            Console.WriteLine("Registration Number : " + listofbranch[i].Registration_NO);

        }


    }
}

using System;

namespace Project_Degine
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String course_name;
            string name;
            int id;
            Student []stud = new Student[50];
            Student stud1 = new Student();
            Student stud2= new Student();
            Staff []staff = new  Staff[50];
            Staff staff1 = new Staff("oop1","ka",55);
            Staff staff3 = new Staff("oop1", "ka", 56);
            Staff staff2 = new Staff();
            Branch b = new Branch("AIUB", "1102");


            Console.WriteLine("Welcome to Attendence Management System");
            do
            {
                Console.WriteLine("-----Welcome to the menu-----");
                Console.WriteLine("[1]-Student");
                Console.WriteLine("[2]-Staff");
                Console.WriteLine("[3]-Admin");
                Console.WriteLine("[4]-Exit the Menu");
                Console.Write("\nEnter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        {
                            int option1;
                            do
                            {
                                Console.WriteLine("\n---Welcome to Student Side---");
                                Console.WriteLine("[1]-Student Information");
                                Console.WriteLine("[2]-Apply Leave");
                                Console.WriteLine("[3]-Aply Complain");
                                Console.WriteLine("[4]-View Attendence");
                                Console.WriteLine("[5]-LOg out Student Side");
                                Console.Write("\nEnter your choice  : ");
                                option1 = Convert.ToInt32(Console.ReadLine());
                                switch (option1)
                                {
                                    case 1:
                                        {
                                           /* for (int i = 0; i < 2; i++)
                                            {
                                                stud[i] = new Student();

                                                Console.Write("Enter Course Name  :");
                                                stud[i].Course_name = course_name = Console.ReadLine();
                                                Console.Write("Enter Student Name :");
                                                stud[i].Name = name = Console.ReadLine();
                                                Console.Write("Enter the ID       :");
                                                stud[i].Id = id = Console.ReadLine();
                                                Console.WriteLine("\n");
                                            }*/
                                            stud[0] = new Student("op1", "tu", 11);
                                            stud[1] = new Student("op2", "re", 22);
                                            Console.Clear();
                                            break;
                                        }                                       
                                    case 2:
                                        {

                                            Console.WriteLine("-----Dear Sir/Mam I want To Leave the class----");
                                            Console.Write("Enter Course Name     :");
                                            stud1.Course_name = course_name = Console.ReadLine();
                                            Console.Write("Enter Student Name    :");
                                            stud1.Name = name = Console.ReadLine();
                                            Console.Write("Enter the ID          :");
                                            stud1.Id =id= Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Why You Want To Leave :");
                                            stud1.Cause=Console.ReadLine();

                                            stud1.appllyLeave();

                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("-----Apply Complain Information-----");
                                            Console.WriteLine("-----Please Fill Up proper Information");
                                            Console.Write("Enter Departmant Name                 :");
                                            stud2.Course_name = course_name = Console.ReadLine();
                                            Console.Write("Enter Student Name                    :");
                                            stud2.Name = name = Console.ReadLine();
                                            Console.Write("Enter the ID                          :");
                                            stud2.Id = id = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Tell me your reason for the complain  :");
                                            stud2.Cause = Console.ReadLine();
                                            stud2.appplyComplain(stud1);


                                            break;
                                        }
                                    case 4:
                                        {
                                            int i = 0;
                                            stud[i].viewAttendence();

                                            break;
                                        }                             
                                    case 5:
                                        {
                                            Console.WriteLine("==============================");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Wrong Choice:");
                                            break;
                                        }
                                }
                            } while (option1 != 5);
                            {
                                Console.WriteLine("Thanks for Using");
                                Console.Clear();
                            }
                            Console.Clear();
                            break;
                            
                        }
                    case 2:
                        {
                            int option1;
                            do
                            {
                                Console.WriteLine("\n---Welcome to Staff Side---\n");                  
                                 Console.WriteLine("[1]-Staff Information");
                                Console.WriteLine("[2]-Add Student");
                                Console.WriteLine("[3]-Add Attendence");
                                Console.WriteLine("[4]-Modify Attendence");
                                Console.WriteLine("[5]-View Attendence");
                                Console.WriteLine("[6]-Manage Leave");
                                Console.WriteLine("[7]-Manage Complain");
                                Console.WriteLine("[8]-Exit Staff Side");
                                Console.Write("\nEnter your choice  : ");
                                option1 = Convert.ToInt32(Console.ReadLine());
                                switch (option1)
                                {
                                    case 1:
                                        {

                                            /* for (int i = 0; i < 2; i++)
                                             {
                                                 staff[i] = new Staff();
                                                 Console.Write("Enter Course Name   :");
                                                 String Course_name = Console.ReadLine();
                                                 Console.Write("Enter Staff Name    :");
                                                 string Name = Console.ReadLine();
                                                 Console.Write("Enter Stsff ID      :");
                                                 Id = Convert.ToInt32(Console.ReadLine()); 
                                                 staff[i].Course_name = (Course_name);
                                                 staff[i].Name = (Name);
                                                 staff[i].Id = (Id);
                                                 Console.WriteLine("\n");
                                             }*/
                                            staff[0] = new Staff("op1", "kf", 55);
                                            staff[1] = new Staff("op2", "rk", 44);
                                            Console.Clear();
                                            break;
                                        }
                                    case 2:
                                        {
                                            for (int i = 0; i < 2; i++)
                                            {
                                                staff[i].addStudent(stud[i]);
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("-----Attendence-----");
                                            Console.WriteLine("Enter Student Attendence");
                                            for (int i = 0; i < 2; i++)
                                            {

                                                Console.Write(stud[i].Id + "\t" + stud[i].Name + "\t");
                                                string attendence = Console.ReadLine();
                                                staff[i].addAttendence(attendence);
                                            }
                                            Console.Clear();
                                            break;
                                           
                                        }
                                    case 4:
                                        {
                                            /* Console.WriteLine("How many students want to modify attendance");
                                             int n = Convert.ToInt32(Console.ReadLine());
                                             for (int i=0; i<n; i++)
                                             {
                                                 staff[i].modifyAttendence();
                                             }   */
                                            Console.WriteLine("Enter Student Id Whose attendance you want to modify ");
                                            id = Convert.ToInt32(Console.ReadLine());                                   
                                            for (int i = 0; i<2; i++)
                                            {
                                                if (stud[i].Id == id)
                                                {
                                                    staff[i].modifyAttendence(stud[i]);
                                                }

                                            }
                                            Console.Clear();
                                            break;
                                        }
                                    case 5:
                                        {
                                            int i = 0;
                                            staff[0].viewAttendence();
                                            staff[1].viewAttendence();

                                            break;
                                        }
                                    case 6:
                                        {
                                            for (int i = 0; i < 2; i++)
                                            {
                                                if (stud[i].Id == stud1.Id)
                                                {
                                                    staff1.manageLeave(stud1);
                                                }
                                               
                                            }

                                            break;
                                        }
                                    case 7:
                                        {
                                            for (int i = 0; i < 2; i++)
                                            {
                                                if (stud[i].Id == stud2.Id)
                                                {
                                                    staff2.manageComplain(stud2);
                                                }

                                            }


                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.WriteLine("==============================");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Wrong Choice:");
                                            break;
                                        }
                                }
                            } while (option1 != 8);
                            {
                                Console.WriteLine("Thanks for Using");
                                Console.Clear();
                            }
                            break;

                        }

                    case 3:
                        {

                            Admin ad = new Admin();
                            /*ad.addStaff(staff1);
                            ad.addStaff(staff2);
                            ad.addBranch(b);
                            ad.show_Branch_details();
                            ad.modifyBranch(b);
                            ad.show_Branch_details();*/
                            ad.viewAttendence();



                            break;
                        }

                    case 4:
                        {
                            //lib.showlibInfo();
                            break;
                        }

                    case 5:
                        {
                            Console.Write("Enter Libray Name:");
                            String libname = Console.ReadLine();
                            Console.Write("Library Address:");
                            String address = Console.ReadLine();
                            //lib.setlibName(libname);
                            //lib.setlibAddress(address);
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("==============================");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Wrong Choice:");
                            break;
                        }
                }

            } while (choice != 6);
            {
                Console.WriteLine("Thanks for Using");
            }
        }
    }              
}
